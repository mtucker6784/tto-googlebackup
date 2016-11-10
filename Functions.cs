using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TuckerTech_GABackup_GUI
{
    public class exfunctions : Form1
    {
        Form1 sendtolog = new Form1();
        public static void CreateSubDir(string savelocation)
        {
            Console.WriteLine("CREATING SUBDIR: " + savelocation);
            string directoryname = (savelocation + "folderlog.txt"); // Folder log created by the folder record f(x)
            string filename = (savelocation + ".deltalog.tok"); // The changed file list generated from changed files f(x)
            string filedirectory = (savelocation + ".folderlog.log"); // This is the new log file that will be created once the sub dirs are relocated.

            var lines = File.ReadLines(directoryname)
                        .Select(line => line.Split(','))
                        .Where(item => item.All(part => !string.IsNullOrWhiteSpace(part)))
                        .ToList();

            var result = from a in lines.AsParallel()
                         from b in lines.AsParallel()
                         where a[0] == b[2]
                         select new { a, b, };

            StreamWriter finaldir = new StreamWriter(filedirectory);

           foreach (var x in result)
            {
                try
                {
                    if (x.b[2] == "0")
                    {
                        Console.Write("Root directory, skipping.\n");
                        return;
                    }
                    string match1 = string.Join(",", x.a[0]);
                    string match2 = string.Join(",", x.b[2]);
                    
                    //MessageBox.Show("A Series: " + x.a[0] + " " + x.a[1] + " " + x.a[2] +"\n\nB Series: " + x.b[0] + " " + x.b[1] + " " + x.b[2]);
                    if (match1 == match2)
                    {
                        Directory.Move(savelocation + x.b[3], x.a[1] + x.b[3]);
                        Console.WriteLine("Moving sub directory: " + x.a[1] + x.b[3] + "\n");
                        
                        finaldir.WriteLine(x.b[2] + "," + x.a[1] + x.b[3] + "," + x.a[1] + "," + x.b[3] + "," + x.b[0]);
                    }
                    else
                    {
                        finaldir.Write(x.b[2] + "," + savelocation);
                        Console.WriteLine("next...");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToString().Contains("DirectoryNotFound"))
                    {
                        Console.WriteLine("Error: " + ex.Message.ToString() + " Status: Carrying on");
                    }
                }
            }
            finaldir.Flush();
            finaldir.Close();
        }

        public static void MoveFiles(string savelocation)
        {
            string directoryname = (savelocation + "folderlog.txt");    // Folder log created by the folder record f(x)
            string filename = (savelocation + ".deltalog.tok");         // The changed file list generated from changed files f(x)
            string filedirectory = (savelocation + ".folderlog.log");   // This is the new log file that will be created once the sub dirs are relocated.
            string ext = null;
            string destfile = null;
            string origfile = null;

            var filedir = File.ReadLines(directoryname)
                        .Select(line => line.Split(','))
                        .Where(item => item.All(part => !string.IsNullOrWhiteSpace(part)))
                        .ToList();

            var filelines = File.ReadLines(filename)
                        .Select(line => line.Split(','))
                        .Where(item => item.All(part => !string.IsNullOrWhiteSpace(part)))
                        .ToList();

            var fulldirpath = File.ReadLines(filedirectory)
                    .Select(line => line.Split(','))
                    .Where(item => item.All(part => !string.IsNullOrWhiteSpace(part)))
                    .ToList();

            var movefile = from a in filedir.AsParallel()    // folderlog.txt (created by folder record earlier)
                           from b in filelines.AsParallel()  // New / changed file .deltalog.tok file.
                           from c in fulldirpath.AsParallel()
                           where a[0] == b[3] && b[3] != null || b[3] != "" && c[0] != a[1] // where folderlog.txt's folderID is equal to deltalog.tok's folder ID
                           select new { a, b, c };

            // Move files to the correct folders
            Console.WriteLine("Time to move files");
            foreach (var x in movefile)
            {
                try
                {
                    switch (x.b[2])
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
                            ext = ".ggl";
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
                        default:
                            ext = ".ggl";
                            break;
                    }
                    origfile = Path.Combine(savelocation, x.b[1] + ext);
                    if (!File.Exists(origfile))
                        continue;
                    x.a[1] = x.a[1].Replace('"', '\\');
                    if (x.b[3] == x.c[4])
                    {
                        destfile = (x.c[1] + "\\" + x.b[1] + ext);
                        Console.WriteLine("Moving file: " + origfile + " To: " + destfile);
                        File.Move(origfile, destfile);
                        continue;
                    }
                    else if (x.a[0] == x.b[3])
                    {
                        destfile = (x.a[1] + "\\" + x.b[1] + ext);
                        Console.WriteLine("Moving file: " + origfile + " To: " + destfile);
                        File.Move(origfile, destfile);
                        continue;
                    }
                    else
                    {
                        //Console.WriteLine("Next!\n");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString() + " Status: Carrying on");
                }
            }
        }

        public static void RecordFolderList(string savedStartPageToken, string pageToken, string user, string savelocation)
        {
            
            Console.WriteLine("RECORDFOLDERLIST(): " + savelocation);
            Form1 sendtolog = new Form1();
            //sendtolog.TxtLog = "Recording folders to file...";
            FilesResource.ListRequest request1 = null;
            StreamWriter folderlog = new StreamWriter(savelocation + "folderlog.txt", true);
            StreamWriter logFile = new StreamWriter(savelocation + ".recent.log");
            string filename = (savelocation + "folderlog.txt");
            request1 = CreateService.BuildService(user).Files.List();
            request1.Q = @"mimeType='application/vnd.google-apps.folder'";
            request1.Fields = "files";
            request1.Spaces = "drive";
            request1.PageSize = 1000;
            var changes = request1.Execute();
            foreach (var change in changes.Files)
            {
                try
                {
                    string folderid = "";
                    string updatedfile = change.Name;
                    string mimetype = change.MimeType;
                    if (change.Parents != null)
                    {
                        var subfolderreq = CreateService.BuildService(user).Files.Get(change.Id);
                        subfolderreq.Fields = "id,name,parents";
                        var sendreq = subfolderreq.Execute();
                        List<string> subfolder = new List<string>();
                        subfolder.Add(sendreq.Name);
                        foreach (string sub in subfolder)
                        {
                            folderid = String.Join(",", change.Parents);
                            folderid = ("," + folderid + "," + sub.ToString());
                            string subreplace = sub.Replace(":", "_");
                            Console.WriteLine("Creating directory: " + savelocation+subreplace.ToString());
                            updatedfile = subreplace.ToString();
                            Directory.CreateDirectory(savelocation+subreplace.ToString());
                        }
                    }

                    updatedfile = updatedfile.Replace(":", "_");
                    string dirname = (savelocation + updatedfile + "\\");
                    
                    //If it's a folder, let's create it now so we can move files into it later.
                    if (mimetype.Contains("folder"))
                    {

                        if (change.Parents == null)
                        {
                            folderlog.WriteLine(change.Id + "," + dirname + folderid + "," + "0" + "," + "1");
                            folderlog.Flush();
                            Console.WriteLine("Creating directory: " + dirname);
                            Directory.CreateDirectory(dirname);
                        }
                        else
                        {
                            folderlog.WriteLine(change.Id + "," + dirname + folderid + "," + "0");
                            folderlog.Flush();
                            Directory.CreateDirectory(dirname);
                        }
                    }
                }
                catch (Exception ex)
                {
                    logFile.WriteLine(ex.Message.ToString());
                    logFile.Flush();
                    Console.WriteLine("Oops!: " + ex.Message.ToString());
                }

            }

            logFile.Close();
            logFile.Dispose();
            folderlog.Close();
            folderlog.Dispose();
            CreateSubDir(savelocation);
        }
        public static void ChangesFileList(string savedStartPageToken, string pageToken, string user, string savelocation)
        {
            string bigfiles = ConfigurationManager.AppSettings["bigfiles"];
            int intbigfiles = int.Parse(bigfiles);
            intbigfiles = ((intbigfiles*1024)*1024);
            Form1 sendtolog = new Form1();
            sendtolog.TxtLog = "Noting files for download. Please wait.";
            int x = 0;
            if (File.Exists(savelocation + ".deltalog.tok"))
                File.Delete(savelocation + ".deltalog.tok");
            var start = CreateService.BuildService(user).Changes.GetStartPageToken().Execute();
            using (StreamWriter deltalog = new StreamWriter(savelocation + ".deltalog.tok", true))
            {
                StreamWriter logFile = new StreamWriter(savelocation + ".recent.log");
                while (pageToken != null)
                {
                    var request = CreateService.BuildService(user).Changes.List(pageToken);
                    request.Fields = "changes,kind,newStartPageToken,nextPageToken";
                    request.RestrictToMyDrive = false;
                    request.PageSize = 1000;
                    request.IncludeRemoved = false;
                    request.Spaces = "drive";
                    var changes = request.Execute();
                    foreach (var change in changes.Changes)
                    {
                        try
                        {
                            x++;
                            string folderid = "";
                            string updatedfile = "";
                            updatedfile = change.File.Name;
                            string mimetype = change.File.MimeType;
                            long? filesize = change.File.Size;
                            if (change.File.Parents != null)
                            {
                                folderid = String.Join(",", change.File.Parents);
                            }
                            //Form1.proUserclass.Value = x;
                            // Record the changed file
                            // Let's...not backup every file on Earth. Check user options and determine if we want to consume our backup resources to downloading a file that -probably isn't- a normal document (ie: uploaded video/movie)
                            // Check the bigfiles appsetting. If the file is bigger than 100mb, skip it.
                            if (bigfiles != "") // Is there input in the "skip files over X MB" textbox.
                            {
                                if (filesize >= intbigfiles) // 104857600 == 100MB
                                {
                                    //
                                }
                                else
                                {
                                    updatedfile = updatedfile.Replace(",", "_").Replace("\"", "_").Replace("(", "-").Replace(")", "-").Replace("?", "_").Replace("<", "_").Replace(">", "_").Replace(";", "_").Replace("$", "_").Replace("@", "_").Replace("!", "_").Replace("|", "_").Replace(":", "_");
                                    logFile.WriteLine(user + ": New or changed file found: " + change.FileId + " --- " + updatedfile);
                                    logFile.Flush();
                                    if (updatedfile.Length >= 35)
                                    {
                                        updatedfile = (updatedfile.Substring(0,35) + "...");
                                    }
                                    if (mimetype == "application/vnd.google-apps.folder")
                                    {
                                        //
                                    }

                                    else
                                    {
                                        deltalog.WriteLine(change.FileId + "," + updatedfile + "," + mimetype + "," + folderid);
                                        deltalog.Flush();
                                    }
                                }
                            }
                            else
                            { 
                            updatedfile = updatedfile.Replace(",", "_").Replace("\"", "_").Replace("(", "-").Replace(")", "-").Replace("?", "_").Replace("<", "_").Replace(">", "_").Replace(";", "_").Replace("$", "_").Replace("@", "_").Replace("!", "_").Replace("|","_").Replace(":","_");
                            logFile.WriteLine(user + ": New or changed file found: " + change.FileId + " --- " + updatedfile);
                            logFile.Flush();
                                if (mimetype == "application/vnd.google-apps.folder")
                                {
                                    //
                                }

                                else
                                {
                                    deltalog.WriteLine(change.FileId + "," + updatedfile + "," + mimetype + "," + folderid);
                                    deltalog.Flush();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Google seems to track every file ever created for the user
                            // it also keeps a record of the fileId. Even if a user
                            // deletes the file, it's still retained in Google's record
                            // although the file is no longer available.
                            // We'll throw an error to the user so the program will continue forth.
                            if (ex.Message.ToString().Contains("404"))
                            {
                                Console.WriteLine(user + ": 404 error. Selected record no longer exists.");
                                logFile.WriteLine(user + ": 404 error. Selected record no longer exists.");
                                logFile.Flush();
                            }
                            else
                            {
                                logFile.WriteLine(user + ": Verbatim error: @F(x)_ChangeFileList" + ex.Message.ToString());
                                logFile.Flush();
                            }

                        }

                    }
                    if (changes.NewStartPageToken != null)
                    {
                        // Last page, save this token for the next polling interval
                        savedStartPageToken = changes.NewStartPageToken;
                    }
                    // Bring our token up to date for next run
                    pageToken = changes.NextPageToken;
                    savedStartPageToken = changes.NextPageToken;
                    File.WriteAllText(savelocation + ".currenttoken.tok", start.StartPageTokenValue);

                }
                deltalog.Close();
                logFile.Close();
                deltalog.Dispose();
                logFile.Dispose();
                //Form1.proUserclass.Value = 0;
            }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // exfunctions
            // 
            this.ClientSize = new System.Drawing.Size(814, 667);
            this.Name = "exfunctions";
            this.Text = "TTO: Google Drive Backup";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}
