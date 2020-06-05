using AirPlaneFactoryBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPlaneFactoryDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required]
        public int? ClientId { get; set; }
        [Required]
        public string ClientFIO { get; set; }
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public virtual Product Products { get; set; }
        public virtual Implementer Implementer { set; get; }
        public int? ImplementerId { set; get; }
        public virtual Client Client { set; get; }
        public string ImplementerFIO { set; get; }
    }
}
