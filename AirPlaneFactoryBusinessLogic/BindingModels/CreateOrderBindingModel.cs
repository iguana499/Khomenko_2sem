using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace AirPlaneFactoryBusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ClientFIO { set; get; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
    }
}
