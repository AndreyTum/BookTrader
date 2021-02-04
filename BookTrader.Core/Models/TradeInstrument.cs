using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    // Торговые инструменты
    public class TradeInstrument
    {
        [Key]
        [Required]
        public long InstrumentID { get; set; }

        public string InstrumentName { get; set; }

        public string Index { get; set; }

        // Размер лота
        public int SizeLot { get; set; }

        // Обеспечение
        //public double? Provision { get; set; }

        // Цена
        //public double? Price { get; set; }

        public DateTime? CloseDate { get; set; }


        // Операции
        public ICollection<Operation> Operations { get; set; }


        // Сделки
        public ICollection<Transaction> Transactions { get; set; }


        public override string ToString()
        {
            return $"{InstrumentName} {Index} LOT={SizeLot}";
        }

    }
}
