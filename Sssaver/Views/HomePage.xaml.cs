using System;
using System.Collections.Generic;
using Sssaver.ViewModels;
using Xamarin.Forms;

namespace Sssaver.Views
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel homeViewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = homeViewModel = new HomeViewModel();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await MysteryButton.FadeTo(0, 400);
            MysteryButton.IsVisible = false;
            GoalLabel.IsVisible = true;
        }


    }
}
