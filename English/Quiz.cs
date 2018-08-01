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
using SpeechLib;

namespace English
{
    public partial class Quiz : Form
    {
        public List<string> WrongItem = new List<string>();
        public List<string> ExamItem = new List<string>();
        public int Current = 0;
        public int ErrorCount = 0;
        public Quiz(ListBox box)
        {
            InitializeComponent();
            ErrorCount = 0;
            lblTranslate.Text = "";
            foreach (var item in box.Items)
            {
                ExamItem.Add(item.ToString());
            }
            ExamItem = ExamItem.OrderBy(x => Guid.NewGuid()).ToList();
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
            lblTranslate.Text = string.Empty;
            Current++;
        }

        private void FinishView() 
        {
            if (WrongItem.Count == 0)
                MessageBox.Show("Good!完成測驗");
            else
            {
                string wrongStr ="錯誤單字\n";
                foreach (string item in WrongItem)
                {
                    wrongStr += item + "\n";
                }
                MessageBox.Show(wrongStr);
                
                using (var stream = File.Open(APConfig.oldPath, FileMode.Open, FileAccess.ReadWrite))
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
            if (ErrorCount >= APConfig.errorLimit)
            {
                MessageBox.Show("下次再來!");
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

        private void pbxSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                SpVoiceClass voice = new SpVoiceClass();
                voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(1);//Item(1)男聲
                voice.Speak(lblShow.Text, SpeechVoiceSpeakFlags.SVSFlagsAsync);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbxTransalte_Click(object sender, EventArgs e)
        {
            try
            {
                lblTranslate.Text = "翻譯中.....";
                this.Update();
                lblTranslate.Text = APConfig.TranslateText(lblShow.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
