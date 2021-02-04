using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    // Операции по счету (ввод/вывод денежных средств)
    public class Operation
    {
        [Key]
        [Required]
        public long OperationID { get; set; }

        public DateTime OperationDateTime { get; set; }

        public double Sum { get; set; }

        public string OperationDescription { get; set; }

        // ИД инструмента
        //public long инструментID { get; set; }

        public override string ToString()
        {
            return $"{OperationDateTime} {Sum}р.";
        }
    }
}
