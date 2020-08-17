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
        public String name { get; set; }
        public String surname { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public String email { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

    }
}
