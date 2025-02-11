﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace TsubakiTranslator.BasicLibrary
{
    public class TranslateAPIConfig: ObservableObject
    {
        private string sourceLanguage = "Japanese";

        private bool ttsIsEnabled;
        private string ttsRegion;
        private string ttsResourceKey;

        private bool aliyunIsEnabled;

        private bool baiduIsEnabled;
        private string baiduAppID;
        private string baiduSecretKey;

        private bool caiyunIsEnabled;
        private string caiyunToken;

        private bool deeplIsEnabled;
        private string deeplSecretKey;

        private bool ibmIsEnabled;


        private bool tencentIsEnabled;
        private string tencentSecretID;
        private string tencentSecretKey;

        private bool xiaoniuIsEnabled;
        private string xiaoniuApiKey;

        private bool volcengineIsEnabled;

        private bool yeekitIsEnabled;

        private bool youdaoIsEnabled;

        public string SourceLanguage
        {
            get => sourceLanguage;
            set => SetProperty(ref sourceLanguage, value);
        }

        public bool TTSIsEnabled
        {
            get => ttsIsEnabled;
            set => SetProperty(ref ttsIsEnabled, value);
        }

        public string TTSRegion
        {
            get => ttsRegion;
            set => SetProperty(ref ttsRegion, value);
        }

        public string TTSResourceKey
        {
            get => ttsResourceKey;
            set => SetProperty(ref ttsResourceKey, value);
        }

        public bool AliyunIsEnabled
        {
            get => aliyunIsEnabled;
            set => SetProperty(ref aliyunIsEnabled, value);
        }

        public bool BaiduIsEnabled
        {
            get => baiduIsEnabled;
            set => SetProperty(ref baiduIsEnabled, value);
        }

        public string BaiduAppID
        {
            get => baiduAppID;
            set => SetProperty(ref baiduAppID, value);
        }

        public string BaiduSecretKey
        {
            get => baiduSecretKey;
            set => SetProperty(ref baiduSecretKey, value);
        }

        public bool CaiyunIsEnabled
        {
            get => caiyunIsEnabled;
            set => SetProperty(ref caiyunIsEnabled, value);
        }

        public string CaiyunToken
        {
            get => caiyunToken;
            set => SetProperty(ref caiyunToken, value);
        }

        public bool DeeplIsEnabled
        {
            get => deeplIsEnabled;
            set => SetProperty(ref deeplIsEnabled, value);
        }

        public string DeeplSecretKey
        {
            get => deeplSecretKey;
            set => SetProperty(ref deeplSecretKey, value);
        }

        public bool IbmIsEnabled
        {
            get => ibmIsEnabled;
            set => SetProperty(ref ibmIsEnabled, value);
        }



        public bool TencentIsEnabled
        {
            get => tencentIsEnabled;
            set => SetProperty(ref tencentIsEnabled, value);
        }

        public string TencentSecretID
        {
            get => tencentSecretID;
            set => SetProperty(ref tencentSecretID, value);
        }

        public string TencentSecretKey
        {
            get => tencentSecretKey;
            set => SetProperty(ref tencentSecretKey, value);
        }

        public bool XiaoniuIsEnabled
        {
            get => xiaoniuIsEnabled;
            set => SetProperty(ref xiaoniuIsEnabled, value);
        }

        public string XiaoniuApiKey
        {
            get => xiaoniuApiKey;
            set => SetProperty(ref xiaoniuApiKey, value);
        }

        public bool VolcengineIsEnabled
        {
            get => volcengineIsEnabled;
            set => SetProperty(ref volcengineIsEnabled, value);
        }

        public bool YeekitIsEnabled
        {
            get => yeekitIsEnabled;
            set => SetProperty(ref yeekitIsEnabled, value);
        }

        public bool YoudaoIsEnabled
        {
            get => youdaoIsEnabled;
            set => SetProperty(ref youdaoIsEnabled, value);
        }
    }
}
