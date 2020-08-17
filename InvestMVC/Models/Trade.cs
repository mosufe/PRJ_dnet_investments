using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestMVC.Models
{
    public class Trade
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.Currency)]
        ulong price { get; set; }
    }
}
