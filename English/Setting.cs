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
            txtFile.Text = Quiz.filePath;
            txtNewFile.Text = Main.newFilePath;
            txtErrorCNT.Text = Quiz.ErrorLimit.ToString();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                Quiz.filePath = txtFile.Text;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtNewFile.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                Main.newFilePath = txtNewFile.Text;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Quiz.ErrorLimit = Int32.Parse(txtErrorCNT.Text);
            this.Close();
        }
    }
}
