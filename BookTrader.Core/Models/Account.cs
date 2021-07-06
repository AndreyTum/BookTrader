using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookTrader.Core.Models
{
    // Счет
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }

        [Required]
        public string AccountName { get; set; } = "Счет";

        public DateTime? CloseDate { get; set; } = DateTime.Today;

        [Required]
        public double Total { get; set; } = 0;

        public string AccountDescription { get; set; } = "Описание счета";


        //// Статистика по счету
        //public ICollection<AccountStatistic> AccountStatistics { get; set; }

        //// Тарифы
        //public ICollection<Tariff> Tariffs { get; set; }

        //// Операции по счету
        //public ICollection<Operation> Operations { get; set; }

        //public override string ToString()
        //{
        //    return $"{AccountName} {Total}р.";
        //}
    }
}
