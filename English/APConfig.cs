using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Runtime.InteropServices;
using System.Configuration;
using System.Windows.Forms;
using System.Net;
using SpeechLib;

namespace English
{
    public class APConfig
    {
        public static string oldPath = "";

        public static string newPath = "";

        public static string exportPath = "";

        public static int errorLimit = 3;

        public static string TranslateText(string input, string languagePair = "zh-TW")
        {
            try
            {
                string url = String.Format("http://www.google.com/translate_t?hl=zh-TW&ie=UTF8&text={0}&langpair={1}", input.ToLower(), languagePair);
                WebClient webClient = new WebClient();
                string result = webClient.DownloadString(url);
                result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
                result = result.Substring(result.IndexOf(">") + 1);
                result = result.Substring(0, result.IndexOf("</span>"));
                return result.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Error";
            }
        }

        public static void SpeechEnglish(string txt)
        {
            try
            {
                SpVoiceClass voice = new SpVoiceClass();
                voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(1);
                voice.Speak(txt, SpeechVoiceSpeakFlags.SVSFlagsAsync);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void SpeechChinese(string txt)
        {
            try
            {
                SpVoiceClass voice = new SpVoiceClass();
                voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);//Item(0)中文女聲
                voice.Speak(txt, SpeechVoiceSpeakFlags.SVSFDefault);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
