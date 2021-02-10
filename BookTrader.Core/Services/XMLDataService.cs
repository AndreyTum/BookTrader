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
        /*public async Task<IEnumerable<Account>> GetAccountsDataAsync()
        {
            await Task.CompletedTask;
            return AllAccounts();
        }

        private IEnumerable<Account> AllAccounts()
        {
            using (Context context = new Context())
            {
                var orders = context.Accounts.ToList();
                return orders;
            }
        }*/

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

        //private IEnumerable<SampleCompany> AllCompanies()
        //{
        //    using (Context context=new Context())
        //    {
        //        var companies = context.SampleCompanies.ToList(); ;
        //        return companies;
        //    }            
        //}

        //public async Task<IEnumerable<SampleOrder>> GetGridDataAsync()
        //{
        //    await Task.CompletedTask;
        //    return AllOrders();
        //}

        //public async Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync()
        //{
        //    await Task.CompletedTask;
        //    return AllOrders();
        //}
    }
}
