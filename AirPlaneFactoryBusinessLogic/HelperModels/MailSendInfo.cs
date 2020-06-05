using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneFactoryBusinessLogic.HelperModels
{
    public class MailSendInfo
    {
        public string MailAddress { get; set; }

        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
