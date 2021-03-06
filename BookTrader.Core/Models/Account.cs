﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    // Счет
    public class Account
    {
        [Key]
        [Required]
        public int AccountID { get; set; }

        public string AccountName { get; set; }

        public DateTime? CloseDate { get; set; }

        public double Total { get; set; }

        public string AccountDescription { get; set; }

        // Статистика по счету
        public ICollection<AccountStatistic> AccountStatistics { get; set; }

        // Тарифы
        public ICollection<Tariff> Tariffs { get; set; }

        // Операции по счету
        public ICollection<Operation> Operations { get; set; }

        public override string ToString()
        {
            return $"{AccountName} {Total}р.";
        }
    }
}
