using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrader.Core.Models
{
    // Статистика по счету
    public class AccountStatistic
    {
        public DateTime AccountStatisticDate { get; set; }

        public double Total { get; set; }
    }
}
