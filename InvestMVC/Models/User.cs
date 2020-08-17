using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public String name { get; set; }

        [Required]
        public String surname { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public String email { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

    }
}
