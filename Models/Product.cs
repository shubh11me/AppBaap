using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppBaap.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required,Range(0,700.50)]
        public float price { get; set; }
        [Required]
        public string category { get; set; }
    }
}
