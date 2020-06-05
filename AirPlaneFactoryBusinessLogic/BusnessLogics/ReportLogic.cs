
using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.BusinessLogics;
using AirPlaneFactoryBusinessLogic.HelperModels;
using AirPlaneFactoryBusinessLogic.Interfaces;
using AirPlaneFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneFactoryBusinessLogic.BusnessLogics
{
    public class ReportLogic
    {
        private readonly IComponentLogic componentLogic;

        private readonly IProductLogic productLogic;

        private readonly IOrderLogic orderLogic;
        public ReportLogic(IProductLogic productLogic, IComponentLogic componentLogic, IOrderLogic orderLLogic)
        {
            this.productLogic = productLogic;
            this.componentLogic = componentLogic;
            this.orderLogic = orderLLogic;
        }
        public List<ReportProductComponentViewModel> GetProductComponent()
        {
            var components = componentLogic.Read(null);

            var products = productLogic.Read(null);

            var list = new List<ReportProductComponentViewModel>();

            foreach (var component in components)
            {
                var record = new ReportProductComponentViewModel
                {
                    ComponentName = component.ComponentName,
                    Products = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var product in products)
                {
                    if
                          (product.ProductComponents.ContainsKey(component.Id))
                    {
                        record.Products.Add(new Tuple<string, int>(product.ProductName, product.ProductComponents[component.Id].Item2));
                        record.TotalCount += product.ProductComponents[component.Id].Item2;
                    }
                }
                list.Add(record);
            }
            return list;
        }
        public List<ReportProductOrdersViewModel> GetForgeProductBillet()
        {
            var billets = componentLogic.Read(null);
            var forgeproducts = productLogic.Read(null);
            var list = new List<ReportProductOrdersViewModel>();
            foreach (var billet in billets)
            {
                foreach (var forgeproduct in forgeproducts)
                {
                    if (forgeproduct.ProductComponents.ContainsKey(billet.Id))
                    {
                        var record = new ReportProductOrdersViewModel
                        {
                            ProductName = forgeproduct.ProductName,
                            ComponentName = billet.ComponentName,
                            Count = forgeproduct.ProductComponents[billet.Id].Item2
                        };
                        list.Add(record);
                    }
                }
            }
            return list;
        }
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return orderLogic.Read(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                ProductName = x.ProductName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            })
           .ToList();
        }
        public void SaveComponentsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Изделия",
                Products = productLogic.Read(null)
            });
        }
        public void SaveProductComponentToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                FileName = model.FileName,
                Title = "The list of orders",
                Orders = GetOrders(model)
            });
        }

        [Obsolete]
        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список самолетов",
                Products = GetForgeProductBillet()
            });
        }
    }
}
