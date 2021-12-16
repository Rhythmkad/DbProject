using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbProject.Models
{
    public class Products
    {
        [Required]
        public string Price { get; set; }

        public string Description { get; set; }

        [Key]
        public string Name { get; set; }
    }
}
