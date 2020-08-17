using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestMVC.Models
{
    public class Stock
    {
        public int Id { get; set; }
        
        [Required]
        String code { get; set; }
        [Required]
        [Range(0,100)]
        decimal yield { get; set; }
    }
}
