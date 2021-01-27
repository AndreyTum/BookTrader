using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookTrader.Core.Models
{
    public class Account
    {
        [Key]
        [Required]
        public int AccountID { get; set; }

        public string AccountName { get; set; }

        public DateTime? CloseDate { get; set; }

        public double Total { get; set; }

        public string AccountDescription { get; set; }
    }
}
