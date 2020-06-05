using System;
using System.Collections.Generic;
using AirPlaneFactoryBusinessLogic.ViewModels;
using System.Text;

namespace AirPlaneFactoryBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<ReportProductOrdersViewModel> Furnitures { get; set; }
        public List<ReportOrdersViewModel> Orders { get; set; }
    }
}
