using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.Interfaces;
using AirPlaneFactoryBusinessLogic.ViewModels;
using AirPlaneFactoryListImplement.Models;
using System;
using System.Collections.Generic;

namespace AirPlaneFactoryListImplement.Implements
{
    public class ProductLogic : IProductLogic
    {
        private readonly DataListSingleton source;
        public ProductLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(ProductBindingModel model)
        {
            Product tempProduct = model.Id.HasValue ? null : new Product { Id = 1 };
            foreach (var product in source.Products)
            {
                if (product.ProductName == model.ProductName && product.Id != model.Id)
                {
                    throw new Exception("Уже есть изделие с таким названием");
                }
                if (!model.Id.HasValue && product.Id >= tempProduct.Id)
                {
                    tempProduct.Id = product.Id + 1;
                }
                else if (model.Id.HasValue && product.Id == model.Id)
                {
                    tempProduct = product;
                }
            }
            if (model.Id.HasValue)
            {
            if (tempProduct == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempProduct);
            }
            else
            {
                source.Products.Add(CreateModel(model, tempProduct));
            }
        }
        public void Delete(ProductBindingModel model)
        {
            // удаляем записи по компонентам при удалении изделия
            for (int i = 0; i < source.ProductComponents.Count; ++i)
            {
                if (source.ProductComponents[i].ProductId == model.Id)
                {
                    source.ProductComponents.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.Products.Count; ++i)
            {
                if (source.Products[i].Id == model.Id)
                {
                    source.Products.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private Product CreateModel(ProductBindingModel model, Product product)
        {
            product.ProductName = model.ProductName;
            product.Price = model.Price;
            //обновляем существуюущие компоненты и ищем максимальный идентификатор
            int maxPCId = 0;
            for (int i = 0; i < source.ProductComponents.Count; ++i)
            {
                if (source.ProductComponents[i].Id > maxPCId)
                {
                    maxPCId = source.ProductComponents[i].Id;
                }
                if (source.ProductComponents[i].ProductId == product.Id)
                {
                    // если в модели пришла запись компонента с таким id
                    if
                    (model.ProductComponents.ContainsKey(source.ProductComponents[i].ComponentId))
                    {
                        // обновляем количество
                        source.ProductComponents[i].Count =
                        model.ProductComponents[source.ProductComponents[i].ComponentId].Item2;
                        // из модели убираем эту запись, чтобы остались только не
                    
model.ProductComponents.Remove(source.ProductComponents[i].ComponentId);
                    }
                    else
                    {
                        source.ProductComponents.RemoveAt(i--);
                     }
                }
            }
            // новые записи
            foreach (var pc in model.ProductComponents)
            {
                source.ProductComponents.Add(new ProductComponent
                {
                    Id = ++maxPCId,
                    ProductId = product.Id,
                    ComponentId = pc.Key,
                    Count = pc.Value.Item2
                });
            }
            return product;
        }
        public List<ProductViewModel> Read(ProductBindingModel model)
        {
            List<ProductViewModel> result = new List<ProductViewModel>();
            foreach (var component in source.Products)
            {
                if (model != null)
                {
                    if (component.Id == model.Id)
                    {
                        result.Add(CreateViewModel(component));
                        break;
                    }
                    continue;
                }
                result.Add(CreateViewModel(component));
            }
            return result;
        }
        private ProductViewModel CreateViewModel(Product product)
        {
            // требуется дополнительно получить список компонентов для изделия с
        Dictionary<int, (string, int)> productComponents = new Dictionary<int,
(string, int)>();
            foreach (var pc in source.ProductComponents)
            {
                if (pc.ProductId == product.Id)
                {
                    string componentName = string.Empty;
                    foreach (var component in source.Components)
                    {
                        if (pc.ComponentId == component.Id)
                        {
                            componentName = component.ComponentName;
                            break;
                        }
                    }
                    productComponents.Add(pc.ComponentId, (componentName, pc.Count));
                }
            }
            return new ProductViewModel
            {
                Id = product.Id,
            ProductName = product.ProductName,
                Price = product.Price,
                ProductComponents = productComponents
            };
        }
    }
}
