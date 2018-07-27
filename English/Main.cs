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

namespace English
{
    public partial class Main : Form
    {
        public static string newFilePath = "";
        public Main()
        {
            InitializeComponent();
            RefreshCount();
            Quiz.filePath = ConfigurationManager.AppSettings["FilePath"];
            newFilePath = ConfigurationManager.AppSettings["NewFilePath"];
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string importTxt = txtInput.Text;
            if (importTxt == "")
                return;
            foreach (string item in listWord.Items)
            {
                if (item == importTxt)
                {
                    MessageBox.Show(string.Format("{0} is repeat !!", importTxt));
                    return;
                }
            }
            listWord.Items.Add(importTxt);
            txtInput.Clear();
            RefreshCount();
        }

        private void RefreshCount()
        {
            label1.Text = "總數為:" + listWord.Items.Count.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (Quiz.filePath == "")
            {
                MessageBox.Show("請先設置檔案");
                return;
            }
            if (listWord.Items.Count <= 0)
                return;
            Quiz frm = new Quiz(listWord);
            frm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting frm = new Setting();
            frm.Show();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {
            if (Quiz.filePath == "")
            {
                MessageBox.Show("請先設置檔案");
                return;
            }
            List<string> oldData = new List<string>();
            using (StreamReader sr = new StreamReader(Quiz.filePath))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    oldData.Add(line);
                }
            }
            oldData = RandomSortList(oldData);
            bool repeat = false;
            int cur = 0;
            int point = 0;
            while(cur<5)
            {
                repeat = false;
                if (point == oldData.Count - 1)
                {
                    MessageBox.Show("已經沒有多餘舊資料");
                    break;
                }
                foreach(string item in listWord.Items)
                {
                    if (item == oldData[point])
                    {
                        repeat = true;
                        break;
                    }
                }
                if (!repeat)
                {
                    listWord.Items.Add(oldData[point]);
                    cur++;
                }
                point++;
            }
            RefreshCount(); 
        }

        public List<T> RandomSortList<T>(List<T> ListT)
        {
            Random random = new Random();
            List<T> newList = new List<T>();
            foreach (T item in ListT)
            {
                newList.Insert(random.Next(newList.Count + 1), item);
            }
            return newList;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            listWord.Items.RemoveAt(listWord.SelectedIndex);
        }

        private void btnImportTxT_Click(object sender, EventArgs e)
        {
            if (newFilePath == "")
            {
                MessageBox.Show("請設置檔案");
                return;
            }

            using (var stream = File.Open(newFilePath, FileMode.Open, FileAccess.ReadWrite))
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
    }
}
