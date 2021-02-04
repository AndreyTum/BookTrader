using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    // Тариф
    public class Tariff
    {
        [Key]
        [Required]
        public int TariffID { get; set; }

        public string TariffName { get; set; }

        public DateTime? CloseDate { get; set; }

        // Комиссия бирже в %
        public double ComissionStockExchange { get; set; }

        // Комиссия брокеру в %
        public double ComissionBroker { get; set; }

        // Обслуживание счета
        public double CostService { get; set; }

        // % на свободные средства
        public double AwardFreeMoney { get; set; }

        public string TariffDescription { get; set; }


        // Сделки
        public ICollection<Transaction> Transactions { get; set; }


        public override string ToString()
        {
            return $"{TariffName}";
        }
    }
}
