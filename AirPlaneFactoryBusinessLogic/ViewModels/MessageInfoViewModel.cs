using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;
using AirPlaneFactoryBusinessLogic.Attributes;

namespace AirPlaneFactoryBusinessLogic.ViewModels
{
    [DataContract]
    public class MessageInfoViewModel : BaseViewModel
    {
        [DataMember]
        public string MessageId { get; set; }
        [DataMember]
        [Column(title: "Отправитель", width: 150)]
        public string SenderName { get; set; }
        [DataMember]
        [Column(title: "Дата письма", width: 100)]
        public DateTime DateDelivery { get; set; }
        [DataMember]
        [Column(title: "Заголовок", width: 100)]
        public string Subject { get; set; }
        [DataMember]
        [Column(title: "Текст", width: 150)]
        public string Body { get; set; }
        public override List<string> Properties() => new List<string> { "Id", "SenderName", "DateDelivery", "Subject", "Body" };
    }
}
