﻿using System;
using System.Collections.Generic;
using System.Text;
using TsubakiTranslator.TranslateAPILibrary;

namespace TsubakiTranslator.BasicLibrary
{
    class TranslateHandler
    {
        //对翻译API进行初始化。
        public static LinkedList<ITranslator> GetSelectedTranslators(TranslateAPIConfig translateAPIConfig)
        {
            LinkedList<ITranslator> translators = new LinkedList<ITranslator>();

            if (translateAPIConfig.AliyunIsEnabled)
            {
                ITranslator aliyun = new AliyunTranslator();
                translators.AddLast(aliyun);
            }

            if (translateAPIConfig.BaiduIsEnabled)
            {
                ITranslator baidu = new BaiduTranslator();
                baidu.TranslatorInit(translateAPIConfig.BaiduAppID, translateAPIConfig.BaiduSecretKey);
                translators.AddLast(baidu);
            }

            if (translateAPIConfig.CaiyunIsEnabled)
            {
                ITranslator caiyun = new CaiyunTranslator();
                caiyun.TranslatorInit(translateAPIConfig.CaiyunToken, "");
                translators.AddLast(caiyun);
            }

            if (translateAPIConfig.DeeplIsEnabled)
            {
                ITranslator deepl = new DeepLTranslator();
                deepl.TranslatorInit(translateAPIConfig.DeeplSecretKey, "");
                translators.AddLast(deepl);
            }

            if (translateAPIConfig.GoogleIsEnabled)
            {
                ITranslator google = new GoogleTranslator();
                translators.AddLast(google);
            }

            if (translateAPIConfig.IbmIsEnabled)
            {
                ITranslator ibm = new IBMTranslator();
                translators.AddLast(ibm);

            }

            if (translateAPIConfig.TencentIsEnabled)
            {
                ITranslator tencent = new TencentTranslator();
                tencent.TranslatorInit(translateAPIConfig.TencentSecretID, translateAPIConfig.TencentSecretKey);
                translators.AddLast(tencent);
            }
            if (translateAPIConfig.XiaoniuIsEnabled)
            {
                ITranslator xiaoniu = new XiaoniuTranslator();
                translators.AddLast(xiaoniu);
            }

            if (translateAPIConfig.YandexIsEnabled)
            {
                ITranslator yandex = new XiaoniuTranslator();
                yandex.TranslatorInit(translateAPIConfig.YandexAPIKey, "");
                translators.AddLast(yandex);
            }

            if (translateAPIConfig.YeekitIsEnabled)
            {
                ITranslator yeekit = new YeekitTranslator();
                translators.AddLast(yeekit);
            }

            if (translateAPIConfig.YoudaoIsEnabled)
            {
                ITranslator youdao = new YoudaoTranslator();
                translators.AddLast(youdao);
            }

            Dictionary<string, string> langDict = GetAPISourceLangDict(translateAPIConfig.SourceLanguage);

            foreach (var t in translators)
                t.SourceLanguage = langDict[t.Name];

            return translators;
        }

        public static Dictionary<string,string> GetAPISourceLangDict(string srcLang)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (srcLang.Equals("Japanese"))
            {
                dict.Add("阿里云", "ja");
                dict.Add("百度", "auto");
                dict.Add("彩云", "auto");
                dict.Add("DeepL", "JA");
                dict.Add("谷歌", "auto");
                dict.Add("IBM", "ja");
                dict.Add("腾讯", "auto");
                dict.Add("小牛", "ja");
                dict.Add("Yandex", "ja");
                dict.Add("Yeekit", "ja");
                dict.Add("有道", "jp");
            }
            else if (srcLang.Equals("English"))
            {
                dict.Add("阿里云", "en");
                dict.Add("百度", "auto");
                dict.Add("彩云", "auto");
                dict.Add("DeepL", "EN");
                dict.Add("谷歌", "auto");
                dict.Add("IBM", "en");
                dict.Add("腾讯", "auto");
                dict.Add("小牛", "en");
                dict.Add("Yandex", "en");
                dict.Add("Yeekit", "nen");
                dict.Add("有道", "en");
            }
            return dict;
 
        }



        /// <summary>
        /// 根据翻译类名创建对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fullName">命名空间.类型名</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string fullName)
        {
            //string path = fullName + "," + assemblyName;//命名空间.类型名,程序集
            Type o = Type.GetType(fullName);//加载类型
            object obj = Activator.CreateInstance(o, true);//根据类型创建实例
            return (T)obj;//类型转换并返回
        }
    }
}
