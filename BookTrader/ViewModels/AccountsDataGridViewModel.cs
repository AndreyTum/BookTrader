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
        private readonly ISampleDataService _sampleDataService;

        public ObservableCollection<SampleOrder> Source { get; set; } = new ObservableCollection<SampleOrder>();

        public AccountsDataGridViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public override async void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await _sampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
