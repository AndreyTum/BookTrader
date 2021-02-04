using System;

using BookTrader.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BookTrader.Views
{
    public sealed partial class AccountsDataGridPage : Page
    {
        private AccountsDataGridViewModel ViewModel => DataContext as AccountsDataGridViewModel;

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on AccountsDataGridPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public AccountsDataGridPage()
        {
            InitializeComponent();
        }
    }
}
