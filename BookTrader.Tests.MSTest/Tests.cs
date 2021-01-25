using System;

using BookTrader.Core.Services;
using BookTrader.ViewModels;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using Prism.Windows.Navigation;

namespace BookTrader.Tests.MSTest
{
    // TODO WTS: Add appropriate tests
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        // TODO WTS: Add tests for functionality you add to MainViewModel.
        [TestMethod]
        public void TestMainViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new MainViewModel();
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to MasterDetailViewModel.
        [TestMethod]
        public void TestMasterDetailViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var mockNavService = new Mock<INavigationService>();
            var mockDataService = new Mock<ISampleDataService>();
            var vm = new MasterDetailViewModel(mockNavService.Object, mockDataService.Object);
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to SettingsViewModel.
        [TestMethod]
        public void TestSettingsViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var vm = new SettingsViewModel();
            Assert.IsNotNull(vm);
        }

        // TODO WTS: Add tests for functionality you add to TelerikDataGridViewModel.
        [TestMethod]
        public void TestTelerikDataGridViewModelCreation()
        {
            // This test is trivial. Add your own tests for the logic you add to the ViewModel.
            var mockDataService = new Mock<ISampleDataService>();
            var vm = new TelerikDataGridViewModel(mockDataService.Object);
            Assert.IsNotNull(vm);
        }
    }
}
