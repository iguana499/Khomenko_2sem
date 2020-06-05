using AirPlaneFactoryBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AirPlaneFactoryBusinessLogic.ViewModels
{
   public class ComponentViewModel : BaseViewModel
    {
        [Column(title: "Название компонента", width: 150)]
        public string ComponentName { get; set; }
        public override List<string> Properties() => new List<string> { "Id", "ComponentName" };
    }
}
