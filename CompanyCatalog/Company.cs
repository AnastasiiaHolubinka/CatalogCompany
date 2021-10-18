using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCatalog
{
    public class Company
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The company name is not specified")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Company address not specified")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Недопустимая длина имени")]
        public string CompanyAddress { get; set; }
        [Required]
        [Range(1900, 2021, ErrorMessage = "Incorrect year of foundation")]
        public int FoundationYear { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Incorrect annual revenue")]
        public int AnnualRevenue { get; set; }
        public string BusinessType { get; set; }


    }
}
