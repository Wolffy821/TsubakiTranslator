﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace TsubakiTranslator
{
    /// <summary>
    /// HookResultDisplay.xaml 的交互逻辑
    /// </summary>
    public partial class HookResultDisplay : UserControl
    {
        private Dictionary<string, HookResultItem> HookItemDict;
        private TranslateWindow translateWindow;

        public HookResultDisplay(TranslateWindow translateWindow)
        {
            InitializeComponent();

            HookItemDict = new Dictionary<string, HookResultItem>();
            this.translateWindow = translateWindow;

            translateWindow.TextHookHandler.ProcessTextractor.OutputDataReceived += DisplayHookResult;

        }


        public void DisplayHookResult(object sendingProcess, DataReceivedEventArgs outLine)
        {

            Regex reg = new Regex(@"\[(.*?)\]");
            Match match = reg.Match(outLine.Data);

            if (match.Value.Length == 0)
                return;

            string content = outLine.Data.Replace(match.Value, "").Trim();//实际获取到的内容
            string hookcode = match.Groups[1].Value;

            if(HookItemDict.ContainsKey(hookcode))
                HookItemDict[hookcode].HookData.HookText = content;
            else
            {
                //Dispatcher是一个线程控制器，要控制线程里跑的东西，就要经过它。
                //WPF里面，有个所谓UI线程，后台代码不能直接操作UI控件，需要控制，就要通过这个Dispatcher。
                App.Current.Dispatcher.Invoke((Action)(() =>
                {
                    /// start 你的逻辑代码
                    HookResultItem item = new HookResultItem(hookcode, content, translateWindow);
                    HookItemDict.Add(hookcode, item);
                    DisplayStackPanel.Children.Add(item);
                    ///  end
                }));

            }
        }
    }
}
