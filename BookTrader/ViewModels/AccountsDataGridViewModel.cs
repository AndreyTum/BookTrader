using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using BookTrader.Core.Models;
using BookTrader.Core.Services;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

namespace BookTrader.ViewModels
{
    public class AccountsDataGridViewModel : ViewModelBase
    {
        private readonly IXMLDataService xmlDataService;
        private Context context;

        //public ObservableCollection<Account> Source { get; set; } = new ObservableCollection<Account>();
        private ObservableCollection<Account> source = new ObservableCollection<Account>();
        public ObservableCollection<Account> Source
        {
            get
            {
                if (isVisibleCloseAccounts)
                {
                    return source;
                }
                else
                {
                    return source;//.Where(w => w.CloseDate is null).ToObservableCollection();
                }
            }
            set
            {
                source = value;
            }
        }

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

        public bool IsActivProgressRing { get; set; } = false;


        public DelegateCommand<object> SaveCommand { get; private set; }
        public DelegateCommand<object> AddCommand { get; private set; }
        public DelegateCommand<object> DeleteCommand { get; private set; }

        public AccountsDataGridViewModel(IXMLDataService xmlDataService)
        {
            this.xmlDataService = xmlDataService;

            SaveCommand = new DelegateCommand<object>(Save, CanSave);
            AddCommand = new DelegateCommand<object>(Add, CanAdd);
            DeleteCommand = new DelegateCommand<object>(Delete, CanDelete);
        }

        private bool CanSave(object parameter)
        {
            //bool canSave = false;
            //foreach (var account in context.Accounts)
            //{
            //    if (context.Entry(account).State != EntityState.Unchanged)
            //    {
            //        canSave = true;
            //        break;
            //    }
            //}

            //return canSave;

            return true;
        }

        private async void Save(object parameter)
        {
            await context.SaveChangesAsync();
            CanSave(parameter);
        }

        private bool CanAdd(object parameter)
        {
            return true;
        }

        private async void Add(object parameter)
        {
            Account account = new Account();

            await context.Accounts.AddAsync(account);
            Source.Add(account);
        }

        private bool CanDelete(object parameter)
        {
            return parameter is null ? false : true;
        }

        private void Delete(object parameter)
        {
            if (parameter is Account)
            {
                Source.Remove((Account)parameter);
                context.Accounts.Remove((Account)parameter);
            }
        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            try
            {
                IsActivProgressRing = true;

                context = new Context();
                Source.Clear();

                var data = await xmlDataService.GetAccountsDataAsync(context);

                foreach (var item in data)
                {
                    Source.Add(item);
                }
            }
            finally
            {
                IsActivProgressRing = false;
            }
        }

        public override async void OnNavigatingFrom(NavigatingFromEventArgs e, Dictionary<string, object> viewModelState, bool suspending)
        {
            base.OnNavigatingFrom(e, viewModelState, suspending);

            await context.DisposeAsync();
        }
    }
}
