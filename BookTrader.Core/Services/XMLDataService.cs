using BookTrader.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTrader.Core.Services
{
    public class XMLDataService : ISampleDataService
    {
        private IEnumerable<SampleOrder> AllOrders()
        {
            /*// The following is order summary data
            var companies = AllCompanies();
            return companies.SelectMany(c => c.Orders);*/
            using (Context context = new Context())
            {
                var orders = context.SampleOrders.ToList();
                return orders;
            }
        }

        private IEnumerable<SampleCompany> AllCompanies()
        {
            using (Context context=new Context())
            {
                var companies = context.SampleCompanies.ToList(); ;
                return companies;
            }            
        }

        public async Task<IEnumerable<SampleOrder>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }

        public async Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync()
        {
            await Task.CompletedTask;
            return AllOrders();
        }
    }
}
