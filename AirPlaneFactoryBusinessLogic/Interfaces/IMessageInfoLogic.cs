using System;
using System.Collections.Generic;
using System.Text;
using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.ViewModels;

namespace AirPlaneFactoryBusinessLogic.Interfaces
{
    public interface IMessageInfoLogic
    {
        List<MessageInfoViewModel> Read(MessageInfoBindingModel model);
        void Create(MessageInfoBindingModel model);
    }
}
