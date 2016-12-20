// Created by Mike Tucker
// mtucker6784@gmail.com
// Provided under GPL 3.0 @ http://www.gnu.org/licenses/gpl.html
// Google APIs are provided under APL-2 @ http://www.apache.org/licenses/LICENSE-2.0

using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Gmail.v1;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TuckerTech_GABackup_GUI
{

    public partial class Form1 : Form
    {
        // Google wanted me to define these.
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        CreateService service = new CreateService();

        public string TxtLog
        {
            set
            {
                this.txtLog.Text = value;
            }
        }


        // Define our Messages
        static string nothing2 = ("Nothing to new to save!\n" + Environment.NewLine);
        public Form1()
        {

            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        void Startitup()
        {
            try
            {
                if (txtFile.Text == "")
                {
                    throw new Exception("Please select a file first");
                }
                else
                {

                    CheckForIllegalCrossThreadCalls = false;
                    if (bgW.IsBusy == true)
                    {
                        //proBar1.Value = 0;
                        txtFile.Enabled = true;
                        //proBar1.Visible = false;
                        bgW.CancelAsync();
                        bgLDAP.CancelAsync();
                        btnStart.Text = "Start Backup";
                    }
                    else
                    {
                        if (txtFile.Text == "ldapusers.txt")
                        {
                            btnStart.Text = "Cancel Backup";
                            bgW.RunWorkerAsync();
                        }
                        else
                            btnStart.Text = "Cancel Backup";
                        bgW.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                stripLabel.Text = ex.Message.ToString();
            }
        }
        private void bgW_DoWork(object sender, DoWorkEventArgs e)
        {
            {
                Action<Exception> errorHandler = (ex) => {
                    Console.WriteLine("ERROR: " + ex.Message.ToString());
                };
                try
                {
                    txtFile.ReadOnly = true;
                    btnStart.Text = "Cancel Backup";
                    CheckForIllegalCrossThreadCalls = false;
                    var appSettings = ConfigurationManager.AppSettings;
                    string checkreplace = ConfigurationManager.AppSettings["checkreplace"];
                    string userfile = txtFile.Text;

                    if (bgW.CancellationPending)
                    {
                        e.Cancel = true;
                        stripLabel.Text = "Operation was canceled!";
                    }
                    else
                    {

                        if (bgW.CancellationPending)
                        {
                            e.Cancel = true;
                            stripLabel.Text = "Operation was canceled!";
                        }
                        else
                        {
                            int totalresource = int.Parse(ConfigurationManager.AppSettings["multithread"]);
                            var opts = new ParallelOptions { MaxDegreeOfParallelism = 1 };
                            if (Environment.Is64BitOperatingSystem == true) // x64, let's use all our set preference instead.
                            {
                                opts = new ParallelOptions { MaxDegreeOfParallelism = totalresource };
                            }
                            int arraycount = 0;
                            var curIndex = 0;
                            int usercount = lstBackupUsers.Items.Count;
                            string curdate = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString();
                            StreamWriter logfile = new StreamWriter(Environment.CurrentDirectory + "\\Logs\\MasterLogFile_" + curdate + ".log", true);

                            var checkforfinished = Parallel.ForEach(lstBackupUsers.Items.Cast<ListViewItem>(), opts, name =>
                            {
                                try
                                {
                                    Console.WriteLine("Selecting row: " + arraycount.ToString());
                                    string names = name.SubItems[0].Text;
                                    if (arraycount == usercount)
                                        return;
                                    lstBackupUsers.Items[name.Index].Selected = true;
                                    lstBackupUsers.Items[name.Index].BackColor = Color.CornflowerBlue;
                                    curIndex = Interlocked.Increment(ref arraycount);
                                    stripLabel.Text = "";
                                    Console.WriteLine("Selecting user: " + names.ToString());
                                    txtLog.Text += "Selecting user: " + names.ToString() + Environment.NewLine;
                                    logfile.WriteLine("Selecting user: " + names.ToString() + Environment.NewLine);
                                    scrolltobtm();
                                    txtCurrentUser.Text = names.ToString();
                                    // Define parameters of request.
                                    string user = names.ToString();

                                    // Check if directory exists, create if not.
                                    string savelocation = ConfigurationManager.AppSettings["savelocation"] + user + "\\";
                                    /* 
                                     * Getting ready for Gmail implementation. Dec 01 2016
                                     * 
                                    int totalunread = 0;
                                    UsersResource.LabelsResource.ListRequest request = CreateService.EmailService(names).Users.Labels.List(names);
                                    UsersResource.MessagesResource.ListRequest email = CreateService.EmailService(names).Users.Messages.List(names);
                                    email.Q = "in:unread";
                                    IList<Google.Apis.Gmail.v1.Data.Label> labels = request.Execute().Labels;
                                    IList<Google.Apis.Gmail.v1.Data.Message> emails = email.Execute().Messages;
                                    if (emails != null && emails.Count > 0)
                                    {
                                        foreach (Google.Apis.Gmail.v1.Data.Message emailItem in emails)
                                        {

                                            string forcestring = emailItem.Id.ToString();
                                            Google.Apis.Gmail.v1.Data.Message fullemail = CreateService.EmailService(names).Users.Messages.Get(names, forcestring).Execute();
                                            ListViewItem listitem = new ListViewItem(new[] { fullemail.Payload.Headers[3].Value, fullemail.Payload.Headers[16].Value + " " + fullemail.Payload.Headers[15].Value, fullemail.Snippet, fullemail.Id });
                                            Console.WriteLine("{0}, Date: {1}", fullemail.Snippet, fullemail.Payload.Headers[3].Value);
                                            totalunread++;
                                        }
                                        Console.WriteLine(totalunread);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Notta");
                                    }
                                    */
                                    if (File.Exists(savelocation + ".deltalog.tok"))
                                        File.Delete(savelocation + ".deltalog.tok");
                                    FileInfo testdir = new FileInfo(savelocation);
                                    testdir.Directory.Create();
                                    string savedStartPageToken = "";
                                    var start = CreateService.BuildService(user).Changes.GetStartPageToken().Execute();
                                    //UsersResource.LabelsResource.ListRequest request = CreateService.BuildService(user).
                                    // This token is set by Google, it defines changes made and
                                    // increments the token value automatically. 
                                    // The following reads the current token file (if it exists)
                                    if (File.Exists(savelocation + ".currenttoken.tok"))
                                    {
                                        StreamReader curtokenfile = new StreamReader(savelocation + ".currenttoken.tok");
                                        savedStartPageToken = curtokenfile.ReadLine().ToString();
                                        curtokenfile.Dispose();
                                    }
                                    else
                                    {
                                        // Token record didn't exist. Create a generic file, start at "1st" token
                                        // In reality, I have no idea what token to start at, but 1 seems to be safe.
                                        Console.Write("Creating new token file.\n");
                                        //txtLog.Text += ("Creating new token file.\n" + Environment.NewLine);
                                        StreamWriter sw = new StreamWriter(savelocation + ".currenttoken.tok");
                                        sw.Write(1);
                                        sw.Dispose();
                                        savedStartPageToken = "1";
                                    }
                                    string pageToken = savedStartPageToken;
                                    int gtoken = int.Parse(start.StartPageTokenValue);
                                    int mytoken = int.Parse(savedStartPageToken);
                                    txtPrevToken.Text = pageToken;
                                    txtCurrentToken.Text = gtoken.ToString();
                                    if (gtoken <= 10)
                                    {
                                        Console.WriteLine("Nothing to save!\n" + Environment.NewLine);
                                        txtLog.Text += ("User has nothing to save!" + Environment.NewLine);
                                        scrolltobtm();
                                    }
                                    else
                                    {
                                        if (int.Parse(pageToken) >= int.Parse(start.StartPageTokenValue))
                                        {
                                            Console.WriteLine("No file changes found for " + user + "\n" + Environment.NewLine);
                                            txtLog.Text += ("[" + user + "] No file changes found! Next!" + Environment.NewLine);
                                            scrolltobtm();
                                            return;
                                        }
                                        else
                                        {
                                            // .deltalog.tok is where we will place our records for changed files
                                            Console.WriteLine("Changes detected. Making notes while we go through these.");
                                            lblProgresslbl.Text = "Scanning Drive directory.";
                                            GC.Collect();
                                            // Damnit Google, why did you change how the change fields work?
                                            if (savedStartPageToken == "1")
                                            {
                                                txtLog.Text += Environment.NewLine + "[" + user + "] Recording folder list ..." + Environment.NewLine;
                                                logfile.WriteLine(user + " --- Recording folder list..." + Environment.NewLine);
                                                scrolltobtm();
                                                exfunctions.RecordFolderList(savedStartPageToken, pageToken, user, savelocation);
                                                scrolltobtm();
                                                txtLog.Text += Environment.NewLine + "Recording new/changed list for: " + user + Environment.NewLine;
                                                scrolltobtm();
                                                exfunctions.ChangesFileList(savedStartPageToken, pageToken, user, savelocation);
                                                scrolltobtm();
                                            }
                                            else
                                            {
                                                scrolltobtm();
                                                txtLog.Text += Environment.NewLine + "[" + user + "] Recording folder list ..." + Environment.NewLine;
                                                scrolltobtm();
                                                exfunctions.RecordFolderList(savedStartPageToken, pageToken, user, savelocation);
                                                scrolltobtm();
                                                txtLog.Text += Environment.NewLine + "[" + user + "] Recording new/changed files ..." + Environment.NewLine;
                                                scrolltobtm();
                                                exfunctions.ChangesFileList(savedStartPageToken, pageToken, user, savelocation);
                                                scrolltobtm();
                                            }

                                            // Get all our files for the user. Max page size is 1k
                                            // after that, we have to use Google's next page token
                                            // to let us get more files.
                                            StreamWriter logFile = new StreamWriter(savelocation + ".recent.log");
                                            string[] deltafiles = File.ReadAllLines(savelocation + ".deltalog.tok");

                                            int totalfiles = deltafiles.Count();
                                            int cnttototal = 0;
                                            Console.WriteLine("\nFiles to backup:\n");
                                            if (deltafiles == null)
                                            {
                                                return;
                                            }
                                            else
                                            {
                                                double damn = ((gtoken - double.Parse(txtPrevToken.Text)));
                                                damn = Math.Round((damn / totalfiles));
                                                if (damn <= 0)
                                                    damn = 1;
                                                //foreach (var file in deltafiles)
                                                Parallel.ForEach(deltafiles, (file) =>
                                                {
                                                    try
                                                    {
                                                        scrolltobtm();
                                                        txtCurrentUser.Text = user;
                                                        DateTime dt = DateTime.Now;
                                                        string[] foldervalues = File.ReadAllLines(savelocation + "folderlog.txt");
                                                        cnttototal++;
                                                        bgW.ReportProgress(cnttototal);
                                                        proUser.Maximum = int.Parse(txtCurrentToken.Text);
                                                        stripLabel.Text = "File " + cnttototal + " of " + totalfiles;
                                                        double? mathisfun = 1;
                                                        mathisfun = ((100 * cnttototal) / totalfiles);
                                                        if (mathisfun <= 0 || mathisfun >= cnttototal)
                                                            mathisfun = 1;
                                                        double mathToken = double.Parse(txtPrevToken.Text);
                                                        mathToken = Math.Round((damn + mathToken));
                                                        // Bring our token up to date for next run
                                                        txtPrevToken.Text = mathToken.ToString();
                                                        //File.WriteAllText(savelocation + ".currenttoken.tok", mathToken.ToString());
                                                        txtCurrentToken.Text = start.StartPageTokenValue.ToString();
                                                        if (cnttototal == totalfiles)
                                                            exfunctions.MoveFiles(savelocation);
                                                        int proval = int.Parse(txtPrevToken.Text);
                                                        int nowval = int.Parse(txtCurrentToken.Text);
                                                        if (proval >= nowval)
                                                            proval = nowval;
                                                        proUser.Value = (proval);
                                                        lblProgresslbl.Text = ("Current progress: " + mathisfun.ToString() + "% completed.");
                                                        // Our file is a CSV. Column 1 = file ID, Column 2 = File name
                                                        var values = file.Split(',');
                                                        string fileId = values[0];
                                                        string fileName = values[1];
                                                        string mimetype = values[2];
                                                        string folder = values[3];
                                                        string ext = null;
                                                        mimetype = mimetype.Replace(",", "_");
                                                        fileName = GetSafeFilename(fileName);
                                                        Console.WriteLine("Filename: " + values[1]);
                                                        logFile.WriteLine("ID: " + values[0] + " - Filename: " + values[1]);
                                                        logFile.Flush();
                                                        GC.Collect();

                                                        // Things get sloppy here. The reason we're checking MimeTypes
                                                        // is because we have to export the files from Google's format
                                                        // to a format that is readable by a desktop computer program
                                                        // So for example, the google-apps.spreadsheet will become an MS Excel file.
                                                        switch (mimetype)
                                                        {
                                                            case "application/pdf":
                                                                ext = ".pdf";
                                                                break;
                                                            case "application/vnd.google-apps.document":
                                                                ext = ".docx";
                                                                break;
                                                            case "audio/wav":
                                                                ext = ".wav";
                                                                break;
                                                            case "application/vnd.google-apps.spreadsheet":
                                                                ext = ".xlsx";
                                                                break;
                                                            case "application/vnd.google-apps.ritz":
                                                                ext = ".xlsx";
                                                                break;
                                                            case "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet":
                                                                ext = ".xlsx";
                                                                break;
                                                            case "application/vnd.google-apps.kix":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/msword":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/vnd.google-apps.presentation":
                                                                ext = ".pptx";
                                                                break;
                                                            case "application/vnd.google-apps.punch":
                                                                ext = ".pptx";
                                                                break;
                                                            case "application/vnd.google-apps.form":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/vnd.google-apps.freebird":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/vnd.google-apps.drawing":
                                                                ext = ".bmp";
                                                                break;
                                                            case "application/vnd.openxmlformats-officedocument.wordprocessingml.document":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/vnd.openxmlformats-officedocument.presentationml.presentation":
                                                                ext = ".pptx";
                                                                break;
                                                            case "application/vnd.google-apps.drive-sdk":
                                                                ext = ".ggl";
                                                                break;
                                                            case "image/gif":
                                                                ext = ".gif";
                                                                break;
                                                            case "application/vnd.google.drive.ext-type.jpg":
                                                                ext = ".jpg";
                                                                break;
                                                            case "image/jpeg":
                                                                ext = ".jpg";
                                                                break;
                                                            case "application/vnd.google.drive.ext-type.png":
                                                                ext = ".png";
                                                                break;
                                                            case "image/png":
                                                                ext = ".png";
                                                                break;
                                                            case "application/vnd.google.drive.ext-type.gif":
                                                                ext = ".gif";
                                                                break;
                                                            case "text/plain":
                                                                ext = ".txt";
                                                                break;
                                                            case "application/vnd.google-apps.audio":
                                                                ext = ".mp3";
                                                                break;
                                                            case "application/vnd.google-apps.file":
                                                                ext = ".docx";
                                                                break;
                                                            case "application/vnd.google-apps.photo":
                                                                ext = ".jpg";
                                                                break;
                                                            case "application/vnd.google-apps.video":
                                                                ext = ".mp4";
                                                                break;
                                                            case "application/vnd.google-apps.script+json":
                                                                ext = ".json";
                                                                break;
                                                            case "text/html":
                                                                ext = ".html";
                                                                break;
                                                            case "application/rtf":
                                                                ext = ".rtf";
                                                                break;
                                                            case "application/vnd.oasis.opendocument.text":
                                                                ext = ".docx";
                                                                break;
                                                            case "text/csv":
                                                                ext = ".csv";
                                                                break;
                                                            case "application/vnd.google-apps.unknown":
                                                                ext = ".ggl";
                                                                break;
                                                            case "application/vnd.google-apps.drive-sdk.758379822725":
                                                                ext = ".ggl";
                                                                break;
                                                            case "application/vnd.google-apps.map":
                                                                ext = ".gglmap";
                                                                break;
                                                            case "application/octet-stream":
                                                                ext = ".txt";
                                                                break;
                                                            default:
                                                                ext = ".ggl";
                                                                break;
                                                        }

                                                        if (ext.Contains(".doc") || ext.Contains(".xls") || ext.Contains(".ppt"))
                                                        {
                                                            string whatami = null;
                                                            if (ext.Contains(".xls"))
                                                            {
                                                                whatami = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                                            }
                                                            else if (ext.Contains(".doc"))
                                                            {
                                                                whatami = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                                                            }
                                                            else if (ext.Contains(".ppt"))
                                                            {
                                                                whatami = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                                                            }
                                                            if (fileName.Contains(".mov") || ext == ".ggl" || fileName.Contains(".mp4"))
                                                            {
                                                                txtLog.Text += Environment.NewLine + "Skipping file.";
                                                                return;
                                                            }

                                                            var requestfileid = CreateService.BuildService(user).Files.Export(fileId, whatami);
                                                            //statusStripLabel1.Text = (savelocation + fileName + ext);
                                                            txtCurrentUser.Text = user;
                                                            string dest1 = Path.Combine(savelocation, fileName + ext);
                                                            var stream1 = new System.IO.FileStream(dest1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                                            scrolltobtm();
                                                            System.Threading.Thread.Sleep(300);
                                                            requestfileid.MediaDownloader.ProgressChanged +=
                                                                     (IDownloadProgress progress) =>
                                                                     {
                                                                         switch (progress.Status)
                                                                         {
                                                                             case DownloadStatus.Downloading:
                                                                                 {
                                                                                     Console.WriteLine(progress.BytesDownloaded);
                                                                                     logFile.WriteLine("Downloading: " + progress.BytesDownloaded);
                                                                                     txtLog.Text += ("Downloading ... " + progress.BytesDownloaded + Environment.NewLine);
                                                                                     logfile.WriteLine("[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     scrolltobtm();
                                                                                     logfile.Flush();
                                                                                     logFile.Flush();
                                                                                     break;
                                                                                 }
                                                                             case DownloadStatus.Completed:
                                                                                 {
                                                                                     Console.WriteLine("Download complete.");
                                                                                     logFile.WriteLine("[" + user + "] Download complete for: " + requestfileid.ToString());
                                                                                     txtLog.Text += ("[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     logfile.WriteLine("[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     logFile.Flush();
                                                                                     logfile.Flush();
                                                                                     break;
                                                                                 }
                                                                             case DownloadStatus.Failed:
                                                                                 {
                                                                                     Console.WriteLine("Download failed.");
                                                                                     logFile.WriteLine("Download failed.");
                                                                                     logFile.Flush();
                                                                                     break;
                                                                                 }
                                                                         }
                                                                     };
                                                            scrolltobtm();
                                                            requestfileid.Download(stream1);
                                                            stream1.Close();
                                                            stream1.Dispose();
                                                        }
                                                        else
                                                        {
                                                            scrolltobtm();
                                                            var requestfileid = CreateService.BuildService(user).Files.Get(fileId);
                                                            //Generate the name of the file, and create it as such on the local filesystem.
                                                            //statusStripLabel1.Text = (savelocation + fileName + ext);
                                                            string dest1 = Path.Combine(savelocation, fileName + ext);
                                                            var stream1 = new System.IO.FileStream(dest1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                                                            System.Threading.Thread.Sleep(500);
                                                            requestfileid.MediaDownloader.ProgressChanged +=
                                                                     (IDownloadProgress progress) =>
                                                                     {
                                                                         switch (progress.Status)
                                                                         {
                                                                             case DownloadStatus.Downloading:
                                                                                 {
                                                                                     Console.WriteLine(progress.BytesDownloaded);
                                                                                     logFile.WriteLine("Downloading: " + progress.BytesDownloaded);
                                                                                     txtLog.Text += ("Downloading ... " + progress.BytesDownloaded + Environment.NewLine);
                                                                                     logfile.WriteLine("[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     scrolltobtm();
                                                                                     logFile.Flush();
                                                                                     logfile.Flush();
                                                                                     break;
                                                                                 }
                                                                             case DownloadStatus.Completed:
                                                                                 {
                                                                                     Console.WriteLine("Download complete.");
                                                                                     logFile.WriteLine("Download complete for: " + requestfileid.ToString());
                                                                                     txtLog.Text += (Environment.NewLine + "[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     logfile.WriteLine("[" + user + "] Download complete for: " + fileName + Environment.NewLine);
                                                                                     logFile.Flush();
                                                                                     logfile.Flush();
                                                                                     break;
                                                                                 }
                                                                             case DownloadStatus.Failed:
                                                                                 {
                                                                                     Console.WriteLine("Download failed.");
                                                                                     logFile.WriteLine("Download failed.");
                                                                                     logFile.Flush();
                                                                                     break;
                                                                                 }
                                                                         }
                                                                     };
                                                            scrolltobtm();
                                                            requestfileid.Download(stream1);
                                                            stream1.Close();
                                                            stream1.Dispose();
                                                        }
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        Console.Write("\nInfo: ---> " + ex.Message.ToString() + "\n");
                                                    }
                                                });
                                            }
                                            exfunctions.MoveFiles(savelocation);
                                            Console.WriteLine("\n\n\tBackup completed for selected user!");
                                            txtLog.Text += (Environment.NewLine + "\n\nBackup completed for selected " + user + "\n\n" + Environment.NewLine);
                                            btnStart.Text = "Start Backup!";
                                            logfile.Flush();
                                            logFile.Close();
                                            logFile.Dispose();
                                        }
                                    }
                                }
                                catch (FormatException ex) { errorHandler(ex); }
                                catch (Google.GoogleApiException ex) { errorHandler(ex); }
                                catch (AggregateException ex) { errorHandler(ex); }
                                catch (OverflowException ex) { errorHandler(ex); }
                                catch (ArgumentNullException ex) { errorHandler(ex); }
                            }
                            );
                            if (checkforfinished.IsCompleted == true)
                            {
                                MessageBox.Show("Backup for all users is complete!");
                                Console.WriteLine("Backup for all users is complete!");
                            }
                            else
                            {
                                MessageBox.Show("Backup for all users was not completed!");
                                Console.WriteLine("Backup for all users was not completed!");
                            }
                            logfile.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex is Google.GoogleApiException || ex is AggregateException || ex is ArgumentNullException)
                    {
                        Console.WriteLine("Info: " + ex.Message.ToString());
                    }
                }

            }
        }

        private void bgW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            proUser.Value = 100;
        }

        private void bgW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //proBar1.Value = 0;
            //proBar1.Visible = false;
            //stripLabel.Text = "Backup finished!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //exfunctions sample = new exfunctions();
            listusers();
        }
        void listusers()
        {
            try
            {
                string location = ConfigurationManager.AppSettings["savelocation"];
                int countdirlen = location.Length;
                lstFiles.Items.Clear();
                string[] allusers = Directory.GetDirectories(location, "*", System.IO.SearchOption.TopDirectoryOnly);
                foreach (string bbq in allusers)
                {
                    listBox1.Items.Add(bbq);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding the save directory location.\nPlease check your backup directory under Preferences and verify the path is accurate.", "Directory error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GetSafeFilename(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }
        private void bgLDAP_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            var appSettings = ConfigurationManager.AppSettings;
            string checkreplace = ConfigurationManager.AppSettings["checkreplace"];
            string defaultdomain = "";
            string replacedomain = "";
            txtFile.Text = @"ldapusers.txt";
            int usercounter = 0;
            if (checkreplace == "yes")
            {
                defaultdomain = ConfigurationManager.AppSettings["defaultdomain"];
                replacedomain = ConfigurationManager.AppSettings["replacedomain"];
            }
            //txtLog.Text += "Discovering users... Please wait." + Environment.NewLine;

            string directorylisttxt = @"ldapusers.txt";
            if (File.Exists(directorylisttxt))
                File.Delete(directorylisttxt);
            string domain = defaultdomain = ConfigurationManager.AppSettings["defaultdomain"];
            StreamWriter userstxt = new StreamWriter(directorylisttxt);
            using (var context = new PrincipalContext(ContextType.Domain, domain))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {

                        if (bgLDAP.CancellationPending)
                        {
                            e.Cancel = true;
                            stripLabel.Text = "Operation was canceled!";
                            break;
                        }

                        usercounter++;
                        stripLabel.Text = (usercounter + " users found.");
                        System.DirectoryServices.DirectoryEntry de = result.GetUnderlyingObject() as System.DirectoryServices.DirectoryEntry;
                        string replace_email = (string)(de.Properties["userPrincipalName"].Value);
                        // Did the user have a valid entry?
                        if (replace_email != null)
                        {
                            if (checkreplace == "yes")
                            {
                                replace_email = replace_email.Replace(defaultdomain, replacedomain);
                                userstxt.WriteLine(replace_email);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid user information. Proceeding to next entry.");
                        }

                    }
                    userstxt.Dispose();
                }

            }
        }

        private void bgLDAP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Text = "Start Backup Now";
            //txtLog.Text += (Environment.NewLine + "Please click \"Start Backup Now\"" + Environment.NewLine);
        }

        private void listcontents(string location)
        {
            try
            {
                lstFiles.Items.Clear();

                string[] userdir = Directory.GetDirectories(location, "*", System.IO.SearchOption.AllDirectories);
                ImageList dirfileimg = new ImageList();
                dirfileimg.Images.Add(new Icon("folder.ico"));              // Default Folder ico [0]
                dirfileimg.Images.Add(new Icon("icons\\fileClean.ico"));    // Default File ico [1]
                dirfileimg.Images.Add(new Icon("icons\\pdf.ico"));          // Default PDF ico [2]
                dirfileimg.Images.Add(new Icon("icons\\excel.ico"));        // Default Excel ico [3]
                dirfileimg.Images.Add(new Icon("icons\\word.ico"));         // Default Word ico [4]
                dirfileimg.Images.Add(new Icon("icons\\ppt.ico"));          // Default PPT ico [5]
                dirfileimg.Images.Add(new Icon("icons\\txt.ico"));          // Default PPT ico [6]
                dirfileimg.Images.Add(new Icon("icons\\sound.ico"));        // Default PPT ico [7]
                dirfileimg.Images.Add(new Icon("icons\\image.ico"));        // Default Img ico [8]
                dirfileimg.ImageSize = new Size(16, 16);
                lstFiles.SmallImageList = dirfileimg;

                ListViewItem backdir = new ListViewItem("..", 0);
                backdir.SubItems.Add("");
                backdir.SubItems.Add(location);
                lstFiles.Items.Add(backdir);
                foreach (string singledir in userdir)
                {
                    DirectoryInfo dir = new DirectoryInfo(singledir);

                    ListViewItem item = new ListViewItem(dir.Name, 0);
                    item.SubItems.Add("");
                    item.SubItems.Add(singledir);
                    lstFiles.Items.Add(item);
                }
                string[] userfiles = Directory.GetFiles(location, "*", SearchOption.AllDirectories);

                foreach (string singlefile in userfiles)
                {
                    FileInfo fileinfo = new FileInfo(singlefile);
                    long filesize = fileinfo.Length;
                    string kbmb = " KB";
                    filesize = (filesize / 1024);
                    if (filesize > 1024)
                    {
                        filesize = (filesize / 1024);
                        kbmb = " MB";
                    }
                    // Start at index 1, where our file icon is.
                    int imgind = 1;
                    if (singlefile.Contains("pdf"))
                        imgind = 2;
                    if (singlefile.Contains("xls"))
                        imgind = 3;
                    if (singlefile.Contains("doc"))
                        imgind = 4;
                    if (singlefile.Contains("ppt"))
                        imgind = 5;
                    if (singlefile.Contains("txt"))
                        imgind = 6;
                    if (singlefile.Contains("mp3") || singlefile.Contains("wmv"))
                        imgind = 7;
                    if (singlefile.Contains(".jpg") || singlefile.Contains(".gif") || singlefile.Contains(".jpeg") || singlefile.Contains(".png") || singlefile.Contains(".bmp"))
                        imgind = 8;
                    ListViewItem item = new ListViewItem(fileinfo.Name, imgind);
                    item.SubItems.Add(filesize.ToString() + kbmb);
                    item.SubItems.Add(singlefile);
                    lstFiles.Items.Add(item);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Oops!", MessageBoxButtons.OK);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listcontents(listBox1.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                ListView.SelectedListViewItemCollection file = lstFiles.SelectedItems;

                foreach (ListViewItem it in file)
                {

                    FileAttributes ass = File.GetAttributes(it.SubItems[2].Text);
                    if (it.SubItems[0].Text.Contains(".."))
                    {
                        listcontents(Directory.GetParent(it.SubItems[2].Text).FullName);
                        break;
                    }
                    if (ass.HasFlag(FileAttributes.Directory))
                    {
                        listcontents(it.SubItems[2].Text);
                        break;
                    }
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = it.SubItems[2].Text;
                    Process p = new Process();
                    p.StartInfo = psi;
                    p.Start();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" " + ex.Message.ToString());
            }
        }

        void Browseforfile()
        {
            try
            {
                txtFile.Enabled = true;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "User text file (*.txt)|*.txt";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtFile.Text = ofd.FileName;
                    using (var sw = new StreamReader(txtFile.Text))
                    {
                        lstBackupUsers.Items.Clear();
                        String auser;
                        while ((auser = sw.ReadLine()) != null)
                        {
                            lstBackupUsers.Items.Add(auser);
                        }
                    }
                }
                else
                {
                    stripLabel.Text = "Browse Canceled!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Browseforfile();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chkOverwrite pref = new chkOverwrite();
            pref.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

            Startitup();
        }

        private void conRestore_Click(object sender, EventArgs e)
        {
            Action<Exception> errorHandler = (ex) => {
                Console.WriteLine("ERROR: " + ex.Message.ToString());
            };
            try
            {
                // Messy. Come back later to fix this.
                string location = ConfigurationManager.AppSettings["savelocation"]; // Get the location
                int loccount = location.Length;                                     // Count the length of the savelocation directory
                string selecteddir = listBox1.SelectedItems[0].ToString();          // Get the full on length of selected option in the listbox
                int selecteddircnt = selecteddir.Length;                            // count the total amount of characters of selection
                string unonly = selecteddir.Remove(0, loccount);                    // Remove the savelocation length from the full directory, leaving us with only the username.
                string rndfileadd = Guid.NewGuid().ToString().Substring(0, 8);      // This is to help mitigate restoring over an existing file. What if we restore a file over a file that was already restored? May as well -try- to avoid that.
                string selectedfile = lstFiles.SelectedItems[0].SubItems[2].Text;
                string findext = selectedfile.Substring(selectedfile.Length - 4);
                string googletype = null;
                ListViewItem fullfilename = lstFiles.SelectedItems[0];
                string temp = fullfilename.SubItems[2].Text;




                txtLog.Text += ("Restoring File \"" + lstFiles.SelectedItems[0].Text + "\" to " + unonly + " root drive" + Environment.NewLine);
                statusStripLabel1.Text = "Restoring " + lstFiles.SelectedItems[0].Text + " ... please wait.";
                Google.Apis.Drive.v3.Data.File fileMetadata = new Google.Apis.Drive.v3.Data.File();
                fileMetadata.Name = lstFiles.SelectedItems[0].Text + "_RESTORE_" + rndfileadd;
                switch (findext)
                {
                    case "xlsx":
                        fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                        googletype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        break;
                    case ".xlsx":
                        fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                        googletype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        break;
                    case ".txt":
                        fileMetadata.MimeType = "text/plain";
                        googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        break;
                    case ".doc":
                        fileMetadata.MimeType = "application/vnd.google-apps.document";
                        googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        break;
                    case "docx":
                        fileMetadata.MimeType = "application/vnd.google-apps.document";
                        googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                        break;
                    case "pptx":
                        fileMetadata.MimeType = "application/vnd.google-apps.presentation";
                        googletype = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                        break;
                    case "ppt":
                        fileMetadata.MimeType = "application/vnd.google-apps.presentation";
                        googletype = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                        break;
                    case ".pdf":
                        fileMetadata.MimeType = "application/pdf";
                        googletype = "application/pdf";
                        break;
                    case ".jpg":
                        fileMetadata.MimeType = "application/vnd.google.drive.ext-type.jpg";
                        googletype = "image/jpg";
                        break;
                    case "jpeg":
                        fileMetadata.MimeType = "application/vnd.google.drive.ext-type.jpg";
                        googletype = "image/jpg";
                        break;
                    case ".png":
                        fileMetadata.MimeType = "application/vnd.google.drive.ext-type.png";
                        googletype = "image/png";
                        break;
                    default:
                        fileMetadata.MimeType = "application/vnd.google-apps.folder";
                        break;
                }
                if (fileMetadata.MimeType == "application/vnd.google-apps.folder")
                {
                    fileMetadata.Name = lstFiles.SelectedItems[0].Text + "_RES_" + rndfileadd;
                    var requestfolder = CreateService.BuildService(unonly).Files.Create(fileMetadata);
                    requestfolder.Fields = "id";
                    var folder = requestfolder.Execute();
                    Console.WriteLine("Folder ID: " + folder.Id);
                    fileMetadata.Parents = new List<string> { folder.Id };
                    string[] allfiles = Directory.GetFiles(temp);
                    FilesResource.CreateMediaUpload requestfile;
                    foreach (string filename in allfiles)
                    {
                        txtLog.Text += "[" + unonly + "] Restoring file: " + filename;
                        findext = filename.Substring(filename.Length - 4);
                        switch (findext)
                        {
                            case "application/pdf":
                                fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                                googletype = "application/pdf";
                                break;
                            case "xlsx":
                                fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                                googletype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                break;
                            case ".xlsx":
                                fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                                googletype = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                                break;
                            case ".txt":
                                fileMetadata.MimeType = "text/plain";
                                googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                                break;
                            case ".doc":
                                fileMetadata.MimeType = "application/vnd.google-apps.document";
                                googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                                break;
                            case "docx":
                                fileMetadata.MimeType = "application/vnd.google-apps.document";
                                googletype = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                                break;
                            case "pptx":
                                fileMetadata.MimeType = "application/vnd.google-apps.presentation";
                                googletype = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                                break;
                            case "ppt":
                                fileMetadata.MimeType = "application/vnd.google-apps.presentation";
                                googletype = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                                break;
                            case ".pdf":
                                fileMetadata.MimeType = "application/pdf";
                                googletype = "application/pdf";
                                break;
                            case ".jpg":
                                fileMetadata.MimeType = "application/vnd.google.drive.ext-type.jpg";
                                googletype = "image/jpg";
                                break;
                            case "jpeg":
                                fileMetadata.MimeType = "application/vnd.google.drive.ext-type.jpg";
                                googletype = "image/jpg";
                                break;
                            case ".png":
                                fileMetadata.MimeType = "application/vnd.google.drive.ext-type.png";
                                googletype = "image/png";
                                break;
                            default:
                                //fileMetadata.MimeType = "text/plain";
                                //googletype = "text/plain";
                                fileMetadata.MimeType = "application/vnd.google-apps.folder";
                                break;
                        }
                        fileMetadata.Name = Path.GetFileName(filename);
                        fileMetadata.Description = "Restored by TTO Backup on " + DateTime.Now;
                        Console.WriteLine("FILENAME: " + filename + "\n");
                        using (var stream = new System.IO.FileStream(filename,
    System.IO.FileMode.Open))
                        {
                            requestfile = CreateService.BuildService(unonly).Files.Create(
    fileMetadata, stream, googletype);
                            requestfile.Fields = "id";
                            requestfile.Upload();
                        }
                        var file = requestfile.ResponseBody;
                        //Console.WriteLine("File id: " + file.Id);
                    }
                }
                else
                {
                    FilesResource.CreateMediaUpload request;
                    using (var stream = new System.IO.FileStream(selectedfile,
                                            System.IO.FileMode.Open))
                    {
                        request = CreateService.BuildService(unonly).Files.Create(
                            fileMetadata, stream, googletype);
                        request.Fields = "id";
                        request.Upload();
                    }
                    var file = request.ResponseBody;
                    txtLog.Text += (lstFiles.SelectedItems[0].Text + " was successfully restored to " + unonly + "'s drive" + Environment.NewLine);
                    statusStripLabel1.Text = "File was successfully restored!";
                    Console.WriteLine("Folder ID is: " + file.Id);
                }
            }
            catch (FormatException ex) { errorHandler(ex); }
            catch (Google.GoogleApiException ex) { errorHandler(ex); }
            catch (AggregateException ex) { errorHandler(ex); }
            catch (OverflowException ex) { errorHandler(ex); }
            catch (ArgumentNullException ex) { errorHandler(ex); }
            catch (Exception ex) { errorHandler(ex); }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Startitup();
        }

        private void conUserMenu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listusers();
        }

        private void conRefreshRight_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            if (listBox1.SelectedItems.Count >= 1)
                listcontents(listBox1.SelectedItem.ToString());

        }

        private void btnSkipFile_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            using (ActiveDir act = new ActiveDir())
            {
                var result = act.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = act.ReturnValue1;
                    txtFile.Text = val;
                    DirectoryEntry allusers = new DirectoryEntry(txtFile.Text);
                    DirectorySearcher allse = new DirectorySearcher(allusers);
                    allse.Filter = "(objectCategory=user)";
                    allse.PropertiesToLoad.Add("sn");
                    allse.PropertiesToLoad.Add("distinguishedName");
                    allse.PropertiesToLoad.Add("givenName");
                    allse.PropertiesToLoad.Add("cn");
                    allse.PropertiesToLoad.Add("sAMAccountName");
                    allse.PropertiesToLoad.Add("mail");
                    // find all matches
                    foreach (SearchResult sr in allse.FindAll())
                    {
                        foreach (string myuser in sr.Properties["mail"])
                        {
                            lstBackupUsers.Items.Add(myuser);
                        }
                    }
                    //string[] names = list.ToArray();
                }
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browseforfile();
        }

        private void OpenAD()
        {
            try
            {
                string space = (ConfigurationManager.AppSettings["defaultdomain"]);
                if (space == "" || space == null)
                {
                    throw new Exception("Domain not set in preferences.");
                }
                lstBackupUsers.Items.Clear();
                using (ActiveDir act = new ActiveDir())
                {
                    var result = act.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string val = act.ReturnValue1;
                        txtFile.Text = val;
                        if (val == "usead")
                        {
                            bgwAD.RunWorkerAsync();
                        }
                        else
                        {
                            DirectoryEntry allusers = new DirectoryEntry(txtFile.Text);
                            DirectorySearcher allse = new DirectorySearcher(allusers);
                            allse.Filter = "(objectCategory=user)";
                            allse.PropertiesToLoad.Add("sn");
                            allse.PropertiesToLoad.Add("distinguishedName");
                            allse.PropertiesToLoad.Add("givenName");
                            allse.PropertiesToLoad.Add("cn");
                            allse.PropertiesToLoad.Add("sAMAccountName");
                            allse.PropertiesToLoad.Add("mail");
                            // /find all matches
                            foreach (SearchResult sr in allse.FindAll())
                            {
                                foreach (string myuser in sr.Properties["mail"])
                                {
                                    lstBackupUsers.Items.Add(myuser);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Problem connecting or talking to your LDAP object.\n\nPlease verify your LDAP domain / settings in the preferences menu and try again. Literal error: " + ex.Message.ToString(), "LDAP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            OpenAD();
        }
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            Startitup();
        }

        private void btnPref_Click(object sender, EventArgs e)
        {
            chkOverwrite pref = new chkOverwrite();
            pref.Show();
        }

        private void openUserFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browseforfile();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkOverwrite pref = new chkOverwrite();
            pref.Show();
        }

        private void openActiveDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAD();

        }

        private void btnSkipUser_Click(object sender, EventArgs e)
        {
            bgW.CancelAsync();
        }

        private void scrolltobtm()
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void lblUnread_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            bgW.CancelAsync();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyTray.Visible = true;
                //notifyTray.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyTray.Visible = true;
            }
        }

        private void notifyTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyTray.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyTray.Visible = false;
        }

        private void bgwAD_DoWork(object sender, DoWorkEventArgs e)
        {
            int usercount = 0;
            DirectoryEntry usead = new DirectoryEntry("LDAP://" + ConfigurationManager.AppSettings["defaultdomain"].ToString());
            DirectorySearcher dsSearch = new DirectorySearcher(usead);
            dsSearch.PageSize = 250;
            dsSearch.Filter = "(objectClass=user)";
            foreach (SearchResult ADResult in dsSearch.FindAll())
            {
                if (ADResult.Properties["mail"].Count > 0)
                {
                    usercount++;
                    Console.WriteLine(usercount.ToString());
                    Console.WriteLine(ADResult.Properties["mail"][0].ToString() + Environment.NewLine);
                    //txtLog.Text += ("Found user #: " + ADResult.Properties["mail"][0].ToString() + Environment.NewLine);
                    stripLabel.Text = "Users added: " + usercount;
                    lstBackupUsers.Items.Add(ADResult.Properties["mail"][0].ToString());
                }
            }
        }
    }



    public class CreateService
    {

        static readonly string SERVICE_ACCOUNT_EMAIL = ConfigurationManager.AppSettings["serviceemail"];
        static readonly string SERVICE_ACCOUNT_PKCS12_FILE_PATH = ConfigurationManager.AppSettings["domainkey"];
        /// <summary>
        /// Build a Drive service object authorized with the service account
        /// that acts on behalf of the given user.
        /// </summary>
        /// @param userEmail The email of the user.
        /// <returns>Drive service object.</returns>
        public static DriveService BuildService(String userEmail)
        {
            try
            {
                X509Certificate2 certificate = new X509Certificate2(SERVICE_ACCOUNT_PKCS12_FILE_PATH,
                    "notasecret", X509KeyStorageFlags.Exportable);
                ServiceAccountCredential credential = new ServiceAccountCredential(
                    new ServiceAccountCredential.Initializer(SERVICE_ACCOUNT_EMAIL)
                    {
                        Scopes = new[] { DriveService.Scope.Drive },
                        User = userEmail
                    }.FromCertificate(certificate));

                // Create the service.
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Drive API Service Account Sample",
                });

                return service;
            }
            catch (Google.GoogleApiException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }
        public static GmailService EmailService(string userEmail)
        {
            try
            {
                X509Certificate2 certificate = new X509Certificate2(SERVICE_ACCOUNT_PKCS12_FILE_PATH,
                    "notasecret", X509KeyStorageFlags.Exportable);
                ServiceAccountCredential credential = new ServiceAccountCredential(
                    new ServiceAccountCredential.Initializer(SERVICE_ACCOUNT_EMAIL)
                    {
                        Scopes = new[] { GmailService.Scope.MailGoogleCom },
                        User = userEmail
                    }.FromCertificate(certificate));

                var service = new GmailService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    ApplicationName = "MyApp",
                    HttpClientInitializer = credential
                });
                return service;
            }
            catch (Google.GoogleApiException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }
    }
}