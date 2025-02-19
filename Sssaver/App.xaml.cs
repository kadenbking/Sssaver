﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sssaver.Services;
using Sssaver.Views;

[assembly: ExportFont("Boldfinger.ttf", Alias = "Bold")]
[assembly: ExportFont("Saira-Regular.ttf", Alias = "Saira")]
[assembly: ExportFont("Saira-SemiBold.ttf", Alias = "Saira-Bold")]

namespace Sssaver
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
