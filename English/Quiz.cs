using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace English
{
    public partial class Quiz : Form
    {
        public static string filePath = "";
        public static int ErrorLimit = 3;
        public static List<string> WrongItem = new List<string>();
        public List<string> ExamItem = new List<string>();
        public int Current = 0;
        public int ErrorCount = 0;
        public Quiz(ListBox box)
        {
            InitializeComponent();
            ErrorCount = 0;
            foreach (var item in box.Items)
            {
                ExamItem.Add(item.ToString());
            }
            ExamItem = ExamItem.OrderBy(x => Guid.NewGuid()).ToList();
            ExamItem = RandomSortList(ExamItem);
            UpdateLable();
        }

        public void UpdateLable()
        {
            if (Current == ExamItem.Count)
            {
                FinishView();
                return;
            }
            lblShow.Text = ExamItem[Current];
            Current++;
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

        private void FinishView() 
        {
            if (WrongItem.Count == 0)
                MessageBox.Show("Good!");
            else
            {
                string wrongStr ="錯誤單字\n";
                foreach (string item in WrongItem)
                {
                    wrongStr += item + "\n";
                }
                MessageBox.Show(wrongStr);
                
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite))
                using (var reader = new StreamReader(stream))
                using (var writer = new StreamWriter(stream))
                {
                    string line = "";
                    List<string> tmpItem = new List<string>(WrongItem);
                    while ((line = reader.ReadLine()) != null)
                    {
                        foreach (string item in tmpItem)
                        {
                            if (item == line)
                            {
                                WrongItem.Remove(item);
                                if (WrongItem.Count == 0)
                                    break;
                            }
                        }
                    }

                    string end = reader.ReadToEnd();
                    if (end.Length != 0 && !end.Equals("\n", StringComparison.Ordinal))
                        writer.Write(Environment.NewLine);
                    
                    foreach (string item in WrongItem)
                    {
                        writer.WriteLine(item);
                    }
                }


            }
            WrongItem.Clear();
            this.Close();
            return;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            UpdateLable();
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            ErrorCount++;
            WrongItem.Add(lblShow.Text);
            if (ErrorCount >= ErrorLimit)
            {
                MessageBox.Show("搞毛?????????????????????????????????");
                FinishView();
                return;
            }
            else
                lblError.Text = string.Format("錯誤: {0}",ErrorCount.ToString());
            UpdateLable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {

        }
    }
}
