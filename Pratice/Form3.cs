using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            txtFile.Text = Form1.filePath;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                Form1.filePath = txtFile.Text;
            }
            this.Close();
        }
    }
}
