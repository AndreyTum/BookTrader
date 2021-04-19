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
        private readonly IXMLDataService xmlDataService;

        public ObservableCollection<Account> Source { get; set; } = new ObservableCollection<Account>();        

        private bool isVisibleCloseAccounts;

        public bool IsVisibleCloseAccounts
        {
            get { return isVisibleCloseAccounts; }
            set
            {
                isVisibleCloseAccounts = value;
                // TODO AND: Сдеалть фильтрацию списка аккаунтов
                //Contact filteredContact = (from c in obsContacts where c.FirstName == filterStr select c).FirstOrDefault();
                Source.Clear();
            }
        }


        public AccountsDataGridViewModel(IXMLDataService xmlDataService)
        {
            this.xmlDataService = xmlDataService;
        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            Source.Clear();
                        
            var data = await xmlDataService.GetAccountsDataAsync();


            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
