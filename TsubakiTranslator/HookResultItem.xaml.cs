﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace TsubakiTranslator
{
    /// <summary>
    /// HookResultItem.xaml 的交互逻辑
    /// </summary>
    public partial class HookResultItem : UserControl
    {
        public HookData HookData { get; }
        private TranslateWindow translateWindow;

        public HookResultItem(string hookCode, string hookText, TranslateWindow translateWindow)
        {
            InitializeComponent();

            HookData = new HookData();
            HookData.HookCode = hookCode;
            HookData.HookText = hookText;

            this.translateWindow = translateWindow;

            this.DataContext = HookData;
        }

        private void Hook_Text_Select_Button_Click(object sender, RoutedEventArgs e)
        {
            translateWindow.TextHookHandler.SelectedHookCode = HookData.HookCode;
            
            translateWindow.SwitchToTranslateDisplay();
        }
    }

    

    public class HookData : ObservableObject
    {

        private string hookCode;
        private string hookText;

        public string HookCode
        {
            get => hookCode;
            set => SetProperty(ref hookCode, value);
        }
        public string HookText
        {
            get => hookText;
            set => SetProperty(ref hookText, value);
        }

    }
}
