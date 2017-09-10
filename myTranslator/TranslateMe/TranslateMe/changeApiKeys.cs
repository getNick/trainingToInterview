using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TranslateMe
{
    public partial class changeApiKeys : Form
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public changeApiKeys()
        {
            InitializeComponent();
            tbTranslateKey.Text = config.AppSettings.Settings["translateKey"].Value;
            tbDictionaryKey.Text = config.AppSettings.Settings["dictionaryKey"].Value;
        }

        private void btnChangeTranslateKey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://translate.yandex.ru/developers/keys");
        }

        private void btnChangeDictionaryKey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tech.yandex.ru/keys/get/?service=dict");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["translateKey"].Value = tbTranslateKey.Text;
            config.AppSettings.Settings["dictionaryKey"].Value = tbDictionaryKey.Text;
            config.Save(ConfigurationSaveMode.Modified);
            this.Close();
        }
    }
}
