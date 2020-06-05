using AirPlaneFactoryBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.Serialization;
using AirPlaneFactoryBusinessLogic.Attributes;

namespace AirPlaneFactoryBusinessLogic.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        [DataMember]
        public int? ClientId { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [Column(title: "Клиент", width: 150)]
        [DataMember]
        public string ClientFIO { get; set; }
        [Column(title: "Изделие", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string ProductName { get; set; }
        [Column(title: "Количество", width: 100)]
        [DataMember]
        public int Count { get; set; }
        [Column(title: "Сумма", width: 80)]
        [DataMember]
        public decimal Sum { get; set; }
        [Column(title: "Исполнитель", width: 70)]
        [DataMember]
        public string ImplementerFIO { set; get; }
        [Column(title: "Статус", width: 100)]
        [DataMember]
        public OrderStatus Status { get; set; }
        [Column(title: "Дата создания", width: 100)]
        [DataMember]
        public DateTime DateCreate { get; set; }
        [Column(title: "Дата выполнения", width: 100)]
        [DataMember]
        public DateTime? DateImplement { get; set; }
        public int? ImplementerId { set; get; }
        public override List<string> Properties() => new List<string> { "Id",
        "ClientFIO", "ProductName", "ImplementerFIO", "Count", "Sum", "Status", "DateCreate",
        "DateImplement" };
    }
}
