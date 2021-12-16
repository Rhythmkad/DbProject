using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DbProject.Models
{
    public class Saleitem
    {
        [Key]
        public string SaleName { get; set; }

        [Required]
        public string Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
