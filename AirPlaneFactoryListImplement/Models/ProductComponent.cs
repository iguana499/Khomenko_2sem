using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneFactoryListImplement.Models
{
    public class ProductComponent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ComponentId { get; set; }
        public int Count { get; set; }
    }
}
