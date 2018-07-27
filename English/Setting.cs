using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class Setting : Form
    {

        public Setting()
        {
            InitializeComponent();
            txtFile.Text = APConfig.oldPath;
            txtNewFile.Text = APConfig.newPath;
            txtExport.Text = APConfig.exportPath;
            txtErrorCNT.Text = APConfig.errorLimit.ToString();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtNewFile.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            APConfig.oldPath = txtFile.Text;
            APConfig.newPath = txtNewFile.Text;
            APConfig.exportPath = txtExport.Text;
            APConfig.errorLimit = Int32.Parse(txtErrorCNT.Text);
            this.Close();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                txtExport.Text = fbd.SelectedPath;
            }
        }
    }
}
