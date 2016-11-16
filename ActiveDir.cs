using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TuckerTech_GABackup_GUI
{
    public partial class ActiveDir : Form
    {
        public string ReturnValue1 { get; set; }
        public ActiveDir()
        {
            InitializeComponent();
        }

        private void ActiveDir_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int x = 0;
                string domain = ConfigurationManager.AppSettings["defaultdomain"];
                DirectoryEntry de = new DirectoryEntry("LDAP://" + domain);
                DirectorySearcher ouSearch = new DirectorySearcher(de,
                                         "(objectClass=organizationalUnit)",
                                         null, SearchScope.Subtree);
                foreach (SearchResult s in ouSearch.FindAll())
                {
                    ListViewItem lv = new ListViewItem(s.GetDirectoryEntry().Name);
                    lv.SubItems.Add(s.GetDirectoryEntry().Path.ToString());
                    lstOUs.Items.Add(lv);
                    x++;
                }
                statusLabel.Text = "OUs found: " + x;
                de.Dispose();
                ouSearch.Dispose();
                Cursor.Current = Cursors.Default;
            }
            catch(Exception ex)
            {
                Cursor.Current = Cursors.Default;
                this.Close();
                MessageBox.Show("Error: " + ex.Message.ToString() + "\nPlease verify that your LDAP domain is correct in the preferences menu.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ReturnValue1 == null || this.ReturnValue1 == "0" && chkAllAD.Checked==false)
                    this.Close();
                if (chkAllAD.Checked)
                {
                    this.ReturnValue1 = "usead";
                    this.Close();
                }
                else
                    this.ReturnValue1 = lstOUs.SelectedItems[0].SubItems[1].Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                this.Close();
            }
        }

        private void lstOUs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ReturnValue1 = lstOUs.SelectedItems[0].SubItems[1].Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAllAD_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAllAD.Checked == true)
                lstOUs.Enabled = false;
            else
                lstOUs.Enabled = true;
        }
    }
}
