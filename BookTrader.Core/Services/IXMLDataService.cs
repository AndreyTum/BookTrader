using BookTrader.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookTrader.Core.Services
{
    public interface IXMLDataService
    {
        Task<IEnumerable<Account>> GetAccountsDataAsync();
    }
}
