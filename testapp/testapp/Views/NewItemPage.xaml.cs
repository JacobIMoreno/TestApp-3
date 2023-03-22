using System;
using System.Collections.Generic;
using System.ComponentModel;
using testapp.Models;
using testapp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testapp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}