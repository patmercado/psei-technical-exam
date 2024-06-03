using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PSEITechnicalExam.Models
{
    public class TransactionModel
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string RefNo { get; set; } = "";

        [Required]
        public long Quantity { get; set; } 

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength (5, MinimumLength = 3)]
        public string Symbol { get; set; } = "";

        [Required]
        public string OrderSide { get; set; } = "";

        [Required]
        public string OrderStatus { get; set; } = "";


    }
}
