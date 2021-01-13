﻿using System;

using BookTrader.ViewModels;

using Microsoft.Toolkit.Uwp.UI.Controls;

using Windows.UI.Xaml.Controls;

namespace BookTrader.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
