using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace TuckerTech_GABackup_GUI
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
            ConfigurationManager.RefreshSection("appSettings");
            Properties.Settings.Default.Reload();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            Properties.Settings.Default.Reload();
            txtDomainKey.Text = ConfigurationManager.AppSettings["domainkey"];
            txtEmail.Text = ConfigurationManager.AppSettings["serviceemail"];
            txtSaveLocation.Text = ConfigurationManager.AppSettings["savelocation"];
            txtDefaultDomain.Text = ConfigurationManager.AppSettings["defaultdomain"];
            txtReplaceDomain.Text = ConfigurationManager.AppSettings["replacedomain"];
            txtBiggerThan.Text = ConfigurationManager.AppSettings["bigfiles"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                Configuration saveconfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                //Remove previous entries
                saveconfig.AppSettings.Settings.Remove("domainkey");
                saveconfig.AppSettings.Settings.Remove("serviceemail");
                saveconfig.AppSettings.Settings.Remove("savelocation");
                saveconfig.AppSettings.Settings.Remove("defaultdomain");
                saveconfig.AppSettings.Settings.Remove("replacedomain");
                //Save the entries
                saveconfig.AppSettings.Settings.Add("domainkey", txtDomainKey.Text);
                saveconfig.AppSettings.Settings.Add("serviceemail", txtEmail.Text);
                saveconfig.AppSettings.Settings.Add("savelocation", txtSaveLocation.Text);
                saveconfig.AppSettings.Settings.Add("defaultdomain", txtDefaultDomain.Text);
                saveconfig.AppSettings.Settings.Add("replacedomain", txtReplaceDomain.Text);
                saveconfig.Save(ConfigurationSaveMode.Full, true);
                ConfigurationManager.RefreshSection("appSettings");
                stripLabel.Text = "Successfully saved settings! Please restart this program.";
            }
            catch(Exception ex)
            {
                stripLabel.Text = "Error: " + ex.Message.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Key file (.p12)|*.p12";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtDomainKey.Text = ofd.FileName;
                }
                else
                {
                    stripLabel.Text = "Browse was canceled!";
                }
            }
            catch(Exception ex)
            {
                stripLabel.Text = ex.Message.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FolderBrowserDialog fold = new FolderBrowserDialog();
                DialogResult result = fold.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtSaveLocation.Text = fold.SelectedPath;
                }
                else
                {
                    stripLabel.Text = "Browse was canceled!";
                }
            }
            catch (Exception ex)
            {
                stripLabel.Text = ex.Message.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveMB_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration saveconfig = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                //Remove previous entries
                saveconfig.AppSettings.Settings.Remove("bigfiles");
                //Save the entries
                saveconfig.AppSettings.Settings.Add("bigfiles", txtBiggerThan.Text);
                saveconfig.Save(ConfigurationSaveMode.Full, true);
                ConfigurationManager.RefreshSection("appSettings");
                stripLabel.Text = "Successfully saved settings!";

            }
            catch (Exception ex)
            {
                stripLabel.Text = "Error: " + ex.Message.ToString();
            }
        }

        private void Preferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void Preferences_Activated(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnCancel_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}

