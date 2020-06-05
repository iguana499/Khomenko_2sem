using AirPlaneFactoryBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace AirPlaneFactoryBusinessLogic.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        [DataMember]
        [Column(title: "Название изделия", width: 150)]
        public string ProductName { get; set; }
        [DataMember]
        [Column(title: "Цена", width: 100)]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ProductComponents { get; set; }
        public override List<string> Properties() => new List<string> { "Id", "ProductName", "Price" };
    }
}
