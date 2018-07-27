using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English
{
    public partial class Export : Form
    {
        public List<string> ExportItem = new List<string>();

        public Export(ListBox box)
        {
            InitializeComponent();
            foreach (var item in box.Items)
            {
                ExportItem.Add(item.ToString());
            }
            txtName.Text = DateTime.Now.ToString("yyyyMMdd");
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(APConfig.exportPath, string.Format("{0}.txt",txtName.Text));
            try
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        foreach (string item in ExportItem)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    MessageBox.Show("成功存檔!");
                    this.Close();
                }
                else
                {
                    var confirmResult = MessageBox.Show("檔案已存在!是否取代?","通知!",MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            foreach (string item in ExportItem)
                            {
                                sw.WriteLine(item);
                            }
                        }
                        MessageBox.Show("成功取代!");
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
