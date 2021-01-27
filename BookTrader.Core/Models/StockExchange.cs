using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    public class StockExchange
    {
        [Key]
        [Required]
        public int StockExchangeID { get; set; }

        public string StockExchangeName { get; set; }


        public string StockExchangeIndex { get; set; }

        public string StockExchangeDescription { get; set; }
    }
}
