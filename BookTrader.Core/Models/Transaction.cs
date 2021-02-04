using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    // Сделка
    public class Transaction
    {
        [Key]
        [Required]
        public long TransactionID { get; set; }

        // Покупка/продажа
        public string TrendTransaction { get; set; }

        // Тип сделки (акции, фьючерсы, облигации...)
        public string TypeTransaction { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public double Sum => Price * Count;

        public Tariff Tariff { get; set; }


        public double SumComissionStockExchange => Sum * Tariff.ComissionStockExchange / 100;

        public double SumComissionBroker => Sum * Tariff.ComissionBroker / 100;

        // Средняя цена после сделки
        public double AvgPrice { get; set; }

        // Количество послед сделки
        public int AvgCount { get; set; }

        // Сумма после сделки
        public double AvgSum { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public string TransactionDescription { get; set; }


        public override string ToString()
        {
            return $"Price={Price} Count={Count} Sum={Sum} Comission={SumComissionStockExchange + SumComissionBroker}";
        }

    }
}
