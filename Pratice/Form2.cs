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

namespace Pratice
{
    public partial class Form2 : Form
    {
        public string filePath = Form1.filePath;
        public List<string> ExamItem = new List<string>();
        public int Current = 0;
        public int FailCount = 0;
        public Form2()
        {
            InitializeComponent();
            ExamItemInit();
            ExamItem = RandomSortList(ExamItem);
            UpdateLable();
        }
        public void ExamItemInit()
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new StreamReader(stream))
            using (var writer = new StreamWriter(stream))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    ExamItem.Add(line.ToString());
                }
            }
        }

        public void UpdateLable()
        {
            if (Current == ExamItem.Count)
            {
                this.Close();
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

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            UpdateLable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
