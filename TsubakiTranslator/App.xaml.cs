﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TsubakiTranslator.BasicLibrary;

namespace TsubakiTranslator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static WindowConfig windowConfig;
        private static GamesConfig gamesConfig;
        private static TranslateAPIConfig translateAPIConfig;

        public static WindowConfig WindowConfig { get => windowConfig; }
        public static GamesConfig GamesConfig { get => gamesConfig; }
        public static TranslateAPIConfig TranslateAPIConfig { get => translateAPIConfig; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            windowConfig = FileHandler.DeserializeObject<WindowConfig>(System.AppDomain.CurrentDomain.BaseDirectory + @"config/WindowConfig.json");
            if(windowConfig == null)
                windowConfig = new WindowConfig();

            gamesConfig = FileHandler.DeserializeObject<GamesConfig>(System.AppDomain.CurrentDomain.BaseDirectory + @"config/GamesData.json");
            if (gamesConfig == null)
                gamesConfig = new GamesConfig();

            translateAPIConfig = FileHandler.DeserializeObject<TranslateAPIConfig>(System.AppDomain.CurrentDomain.BaseDirectory + @"config/APIConfig.json");
            if(translateAPIConfig == null)
                translateAPIConfig = new TranslateAPIConfig();

        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            FileHandler.SerializeObject<WindowConfig>(WindowConfig, System.AppDomain.CurrentDomain.BaseDirectory + @"config/WindowConfig.json");
            FileHandler.SerializeObject<GamesConfig>(GamesConfig, System.AppDomain.CurrentDomain.BaseDirectory + @"config/GamesData.json");
            FileHandler.SerializeObject<TranslateAPIConfig>(TranslateAPIConfig, System.AppDomain.CurrentDomain.BaseDirectory + @"config/APIConfig.json");
        }

    }

    

}
