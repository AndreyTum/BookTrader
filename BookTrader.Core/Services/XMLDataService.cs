using BookTrader.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrader.Core.Services
{
    public class XMLDataService : IXMLDataService
    {
        //public async Task<IEnumerable<Account>> GetAccountsDataAsync()
        //{
        //    await Task.CompletedTask;
        //    //return AllAccounts();
        //    return AllAccounts();
        //}



        //private IEnumerable<Account> AllAccounts()
        //{

        //    try
        //    {
        //        using (Context context = new Context())
        //        {
        //            /*context.Accounts.Add(new Account()
        //            {
        //                AccountID = 1,
        //                AccountName = "TestName",
        //                Total = 100,
        //                AccountDescription = "Тестовый аккаунт"
        //            });
        //            context.SaveChanges();*/

        //            var accounts = context.Accounts.ToList();
        //            return accounts;
        //        }

        //        //return new List<Account>()
        //        //{
        //        //    new Account()
        //        //    {
        //        //        AccountID = 1,
        //        //        AccountName = "TestName",
        //        //        Total = 100,
        //        //        AccountDescription = "Тестовый аккаунт"
        //        //    }
        //        //};
        //    }
        //    catch (Exception ex)
        //    {
        //        string str = ex.Message;
        //        return null;
        //    }

        //}


        public async Task<IEnumerable<Account>> GetAccountsDataAsync()
        {            
            using (Context context = new Context())
            {
                var accounts = context.Accounts.ToListAsync();
                return await accounts;
            }
        }


        //private IEnumerable<SampleOrder> AllOrders()
        //{
        //    /*// The following is order summary data
        //    var companies = AllCompanies();
        //    return companies.SelectMany(c => c.Orders);*/
        //    using (Context context = new Context())
        //    {
        //        var orders = context.SampleOrders.ToList();
        //        return orders;
        //    }
        //}

        /*private IEnumerable<SampleCompany> AllCompanies()
        {
            using (Context context = new Context())
            {
                var companies = context.SampleCompanies.ToList(); ;
                return companies;
            }
        }*/

        /*public async Task<IEnumerable<SampleOrder>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }

        public async Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }*/


        //public async Task<IEnumerable<SampleOrder>> GetGridDataAsync()
        //{
        //    await Task.CompletedTask;
        //    return AllOrders();
        //}

        /*public Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync()
        {
            throw new NotImplementedException();
        }*/
    }
}
