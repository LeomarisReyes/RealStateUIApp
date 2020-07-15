using System;
using System.Collections.Generic;
using RealStateUIApp.ViewModels;
using Xamarin.Forms;

namespace RealStateUIApp.Views
{
    public partial class HousePage : ContentPage
    { 
        public HousePage()
        {
            InitializeComponent();
            BindingContext = new HouseViewModel();
        }
    }
}
