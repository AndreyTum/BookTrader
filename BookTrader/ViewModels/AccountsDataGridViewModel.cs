using System.Collections.Generic;
using System.Collections.ObjectModel;

using BookTrader.Core.Models;
using BookTrader.Core.Services;

using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace BookTrader.ViewModels
{
    public class AccountsDataGridViewModel : ViewModelBase
    {
        private readonly IXMLDataService  xmlDataService;

        public ObservableCollection<Account> Source { get; set; } = new ObservableCollection<Account>();

        public AccountsDataGridViewModel(IXMLDataService xmlDataService)
        {
            this.xmlDataService = xmlDataService;
        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await xmlDataService.GetAccountsDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
