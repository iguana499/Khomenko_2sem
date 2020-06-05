using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AirPlaneFactoryDatabaseImplement.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual List<ProductComponent> ProductComponents { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}