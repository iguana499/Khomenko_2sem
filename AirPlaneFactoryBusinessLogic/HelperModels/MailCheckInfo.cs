using System;
using System.Collections.Generic;
using System.Text;
using AirPlaneFactoryBusinessLogic.Interfaces;

namespace AirPlaneFactoryBusinessLogic.HelperModels
{
    public class MailCheckInfo
    {
        public string PopHost { get; set; }
        public int PopPort { get; set; }
        public IMessageInfoLogic Logic { get; set; }
    }
}
