using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvestMVC.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Marca")]
        String brand { get; set; }

        [Required]
        [Display(Name = "Nome Fantasia")]
        String fantazyName { get; set; }

        [Required]
        [Display(Name = "Site")]
        String website { get; set; }

        byte[] logo { get; set; }

        [Display(Name = "Valor de Mercado")]
        ulong marketValue { get; set; }

        [Display(Name = "Funcionarios")]
        ulong listedEmployees { get; set; }

        [Required]
        [Display(Name = "Fundação")]
        [DataType(DataType.Date)]
        DateTime foundation { get; set; }

        [Required]
        [Display(Name = "Data do IPO")]
        [DataType(DataType.Date)]
        DateTime IPO { get; set; }

        [Required]
        [Display(Name = "Tag Along")]
        [Range(0, 100)]
        String tagAlong { get; set; }

        [Required]
        [Display(Name = "segmento")]
        String segment { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Free float")]
        decimal freeFloat { get; set; }
    }
}
