using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestMVC.Models
{
    public class HistoricalData
    {
        public int Id { get; set; }

        [Required]
        ulong price{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        DateTime time { get; set; }
    }
}
