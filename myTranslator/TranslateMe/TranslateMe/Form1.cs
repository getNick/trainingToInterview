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

namespace TranslateMe
{
    public partial class Form1 : Form
    {
        Translator tr;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Form1()
        {
            InitializeComponent();
            selectLPair.SelectedIndex = 0;
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
            File.AppendAllText(config.AppSettings.Settings["filePath"].Value, tbInput.Text + " - " + tbResult.Text + Environment.NewLine);
            MessageBox.Show("Save to " + config.AppSettings.Settings["filePath"].Value);
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

        private void changeAPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeApiKeys form = new changeApiKeys();
            form.Show();
        }
    }
}
