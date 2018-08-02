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
using System.Configuration;
using SpeechLib;

namespace English
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RefreshCount();
            APConfig.oldPath = ConfigurationManager.AppSettings["oldPath"];
            APConfig.newPath = ConfigurationManager.AppSettings["newPath"];
            APConfig.exportPath = ConfigurationManager.AppSettings["exportPath"];
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
                return;
            if (listWord.Items.Contains(txtInput.Text))
            {
                MessageBox.Show(string.Format("{0} 已經存在 !!", txtInput.Text));
                return;
            }
            listWord.Items.Add(txtInput.Text);
            txtInput.Clear();
            RefreshCount();
        }

        private void RefreshCount()
        {
            label1.Text = "總數為:" + listWord.Items.Count.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (APConfig.oldPath == "")
            {
                MessageBox.Show("請先設置檔案!");
                return;
            }
            if (listWord.Items.Count <= 0)
            {
                MessageBox.Show("請輸入題目!");
                return;
            }
            using (Quiz form = new Quiz(listWord))
            {
                var result = form.ShowDialog();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (Setting form = new Setting())
            {
                var result = form.ShowDialog();
            }
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            if (APConfig.oldPath == "")
            {
                MessageBox.Show("請先設置檔案");
                return;
            }
            #region 導入舊資料
            List<string> oldData = new List<string>();
            using (StreamReader sr = new StreamReader(APConfig.oldPath))
            {
                string line = "";
                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    oldData.Add(line);
                }
            }
            oldData = oldData.OrderBy(x => Guid.NewGuid()).ToList();
            int cur = 0,point = 0;
            while(cur<5)
            {
                if (point == oldData.Count)
                {
                    MessageBox.Show("已經沒有多餘舊資料");
                    break;
                }
                if (!listWord.Items.Contains(oldData[point]))
                {
                    listWord.Items.Add(oldData[point]);
                    cur++;
                }
                point++;
            }
            #endregion
            RefreshCount(); 

        }

        private void btnImportTxT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(APConfig.newPath))
            {
                MessageBox.Show("請設置檔案");
                return;
            }

            using (var stream = File.Open(APConfig.newPath, FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new StreamReader(stream))
            using (var writer = new StreamWriter(stream))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    listWord.Items.Add(line.ToString());
                }
            }
            RefreshCount();
        }


        private void deleteItem()
        {
            if (listWord.Items.Count != 0 && listWord.SelectedIndex != -1)
            {
                int index = listWord.SelectedIndex;
                listWord.Items.Remove(listWord.SelectedItem.ToString());
                listWord.SelectedIndex = index - 1;
                RefreshCount();
            }
        }

        private void listWord_KeyDown(object sender, KeyEventArgs e)
        {
            deleteItem();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (listWord.Items.Count <= 0 && string.IsNullOrEmpty(APConfig.exportPath))
            {
                MessageBox.Show("請設置匯出資料夾!");
                return;
            }
            using (Export form = new Export(listWord))
            {
                var result = form.ShowDialog();
            }
        }

    }
}
