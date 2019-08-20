using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrianasCoreDemoProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }

        [MaxLength(10)]
        public string Status { get; set; }
    }
}
