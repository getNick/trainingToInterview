using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexLinguistics.NET;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Timers;

namespace TranslateMe
{
    public partial class Form1 : Form
    {
        Translator tr;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        Dictionary<string, string> dictionaryList = new Dictionary<string, string>();
        string trueAnswer="";
        Random rnd = new Random();
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            selectLPair.SelectedIndex = 0;
            tbTranslateKey.Text = config.AppSettings.Settings["translateKey"].Value;
            tbDictionaryKey.Text = config.AppSettings.Settings["dictionaryKey"].Value;
            tbFilePath.Text = config.AppSettings.Settings["filePath"].Value;
            selectAllWords.Checked = true;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            tr = new Translator();
            if (tbInput.Text.Split(' ').Length > 1)
            {
                tbResult.Text = tr.translateText(tbInput.Text, tr.GetLangPair(selectLPair.SelectedItem.ToString()));
            }
            else
            {
                tbResult.Text = tr.translateWord(tbInput.Text, tr.GetLangPair(selectLPair.SelectedItem.ToString()));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            while (config.AppSettings.Settings["filePath"].Value == "")
            {
                changeFilePath(null,null);
            }
            File.AppendAllText(config.AppSettings.Settings["filePath"].Value, Environment.NewLine+tbInput.Text + " - " + tbResult.Text);
            //MessageBox.Show("Save to " + config.AppSettings.Settings["filePath"].Value);
        }

        private void changeFilePath(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(config.AppSettings.Settings["filePath"].Value != "")
            {
                openFileDialog1.InitialDirectory = config.AppSettings.Settings["filePath"].Value;
                openFileDialog1.FileName = config.AppSettings.Settings["filePath"].Value.Split('\\').Last();
            }
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                config.AppSettings.Settings["filePath"].Value = openFileDialog1.FileName;
                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        private void btnChangeTranslateKey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.yandex.ru/developers/keys");
        }

        private void btnChangeDictionaryKey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tech.yandex.ru/keys/get/?service=dict");
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["translateKey"].Value = tbTranslateKey.Text;
            config.AppSettings.Settings["dictionaryKey"].Value = tbDictionaryKey.Text;
            config.AppSettings.Settings["filePath"].Value = tbFilePath.Text;
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void bntChangeFilePath_Click(object sender, EventArgs e)
        {
            changeFilePath(null, null);
            tbFilePath.Text = config.AppSettings.Settings["filePath"].Value;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab.Name== "repeatWord")
            {
                LoadDictionary();
                var keyPair = dictionaryList.ElementAt(getRandomWordIndex());
                wordToTranslate.Text = keyPair.Value;
                trueAnswer = keyPair.Key;
            }
        }
        private int getRandomWordIndex()
        {
            return rnd.Next(0, dictionaryList.Count() - 1);
        }
        private void LoadDictionary()
        {
            dictionaryList.Clear();
            var fileStream = new FileStream(config.AppSettings.Settings["filePath"].Value, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var mass = line.Split('-');
                    mass[0]=mass[0].Remove(mass[0].Length-1);
                    mass[1] = mass[1].Remove(0, mass[1].LastIndexOf(']') + 2);
                    dictionaryList.Add(mass[0], mass[1]);
                }
            }
        }

        private void checkAnswer_Click(object sender, EventArgs e)
        {
            if (answer.Text == trueAnswer)
            {
                MessageBox.Show("Congratulations!");
                dictionaryList.Remove(trueAnswer);
                if (dictionaryList.Count == 0)
                {
                    MessageBox.Show("You repeat all words");
                    LoadDictionary();
                }
                var keyPair = dictionaryList.ElementAt(getRandomWordIndex());
                wordToTranslate.Text = keyPair.Value;
                answer.Text = "";
                trueAnswer = keyPair.Key;
            }
            else MessageBox.Show("Fail,try again");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnHelp.Text = trueAnswer;
            /*aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;*/

        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            btnHelp.Text = "Help";
            /*Console.WriteLine("dfja;lksdf");
            aTimer.Stop();
            aTimer.Dispose();*/
        }
    }
}
