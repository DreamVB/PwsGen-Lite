using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DreamVB.RndPassword;
using System.IO;
using System.Diagnostics;

namespace PwnGenLite
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private bool ListHasSelectedItems()
        {
            bool flag = false;

            foreach (ListViewItem li in lstPasswords.CheckedItems)
            {
                if (li.Checked)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private string GetOpenDlgFilename()
        {
            SaveFileDialog sd = new SaveFileDialog();
            string lzFile = string.Empty;

            sd.Title = "Save As";
            sd.Filter = "Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
            sd.FilterIndex = 1;

            if (sd.ShowDialog().Equals(DialogResult.OK))
            {
                lzFile = sd.FileName;
            }

            sd.Dispose();
            return lzFile;
        }

        private StringBuilder Get_Selected()
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem li in lstPasswords.CheckedItems)
            {
                sb.AppendLine(li.SubItems[1].Text);
            }
            return sb;
        }

        private void SaveToFile(string Filename)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem li in lstPasswords.CheckedItems)
            {
                sb.AppendLine(li.Text + "," + li.SubItems[1].Text);
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(Filename))
                {
                    sw.Write(sb.ToString().TrimEnd());
                    sw.Close();
                }
                sb.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MakePwsList(int Length, int Count)
        {
            RandomPassword rp = new RandomPassword();
            //Clear list view
            lstPasswords.Items.Clear();

            rp.Length = Length;
            rp.Uppercase = chkUpper.Checked;
            rp.Lowercase = chkLower.Checked;
            rp.Numbers = chkDigits.Checked;
            rp.Special = chkSpecial.Checked;

            for (int x = 1; x <= Count; x++)
            {
                ListViewItem li = new ListViewItem();
                li.Text = x.ToString();
                li.ImageIndex = 0;
                li.SubItems.Add(rp.Generate());
                lstPasswords.Items.Add(li);
            }

            if (lstPasswords.Items.Count > 0)
            {
                lstPasswords.Items[0].Selected = true;
            }
            lstPasswords.Focus();
            lstPasswords.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void cmdGen_Click(object sender, EventArgs e)
        {
            MakePwsList((int)txtLength.Value, (int)txtCount.Value);
        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lstPasswords.Items)
            {
                li.Checked = true;
            }
            lstPasswords.Focus();
        }

        private void cmdCpySelected_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(Get_Selected().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //Check if there are any item checked.
            if (!ListHasSelectedItems())
            {
                MessageBox.Show("There are not items to save.\nPlease select some items.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lzFile = GetOpenDlgFilename();

            if (lzFile.Length.Equals(0))
            {
                return;
            }
            //
            try
            {
                SaveToFile(lzFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void chkUpper_MouseHover(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.ForeColor = Color.Blue;
        }

        private void chkUpper_MouseLeave(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            cb.ForeColor = Color.Black;
        }

        private void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process p = new Process();

            if (e.Button != MouseButtons.Left)
                return;

            try
            {
                p.StartInfo.FileName = "Readme.txt";
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
