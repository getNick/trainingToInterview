using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;
using System.Configuration;

namespace TranslateMe
{
    class Translator
    {
        YandexLinguistics.NET.Translator tr;
        YandexLinguistics.NET.Dictionary dic;
        public Translator()
        {
            tr = new YandexLinguistics.NET.Translator(ConfigurationManager.AppSettings.Get("translateKey"));
            dic = new YandexLinguistics.NET.Dictionary(ConfigurationManager.AppSettings.Get("dictionaryKey"));
        }
        public LangPair GetLangPair(string stringPair)
        {
            return new LangPair(stringPair);
        }
        public string translateWord(string inputText,LangPair lp)
        {

            var result = dic.Lookup(lp, inputText).Definitions[0];
            List<string> list = new List<string>();
            foreach(var i in result.Translations)
            {
                list.Add(i.Text);
            }
            string transcription = lp.InputLang == Lang.En ? "[" + result.Transcription.ToString() + "] " : "";
            return transcription + string.Join(",",list.ToArray());
        }
        public string translateText(string inputText,LangPair lp)
        {
            return tr.Translate(inputText, lp).Text;
        }
    }
}
