﻿using Regiones.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Regiones.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}