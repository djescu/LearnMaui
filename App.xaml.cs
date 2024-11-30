// Copyright © 2024 David Escudero. All rights reserved.

using LearnMaui.Views;

namespace LearnMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductPage();

            //MainPage = new AppShell();
        }
    }
}
