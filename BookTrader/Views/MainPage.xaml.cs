using System;

using BookTrader.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BookTrader.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
