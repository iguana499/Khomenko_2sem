using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.Enums;
using AirPlaneFactoryBusinessLogic.Interfaces;
using AirPlaneFactoryBusinessLogic.ViewModels;
using AirPlaneFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPlaneFactoryDatabaseImplement.Impliments
{
    public class OrderLogic : IOrderLogic
    {
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new AirPlaneFactoryDatabase())
            {
                Order element;
                if (model.Id.HasValue)
                {
                    element = context.Orders.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Order();
                    context.Orders.Add(element);
                }
                element.ClientId = model.ClientId == 0 ? element.ClientId : model.ClientId;
                element.ProductId = model.ProductId == 0 ? element.ProductId : model.ProductId;
                element.Count = model.Count;
                element.ClientFIO = model.ClientFIO;
                element.ImplementerFIO = model.ImplementerFIO;
                element.ImplementerId = model.ImplementerId == 0 ? element.ImplementerId : model.ImplementerId; ;
                element.Sum = model.Sum;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                context.SaveChanges();
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (var context = new AirPlaneFactoryDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id ==
model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new AirPlaneFactoryDatabase())
            {
                return context.Orders.Where(rec => model == null || rec.Id == model.Id || (rec.DateCreate >= model.DateFrom)
                && (rec.DateCreate <= model.DateTo) || (model.ClientId == rec.ClientId) ||
                (model.FreeOrder.HasValue && model.FreeOrder.Value && !(rec.ImplementerFIO != null)) ||
                (model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId.Value && rec.Status == OrderStatus.Выполняется))
                .Include(ord => ord.Products)
                .Select(rec => new OrderViewModel()
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    ProductId = rec.ProductId,
                    ClientFIO = rec.ClientFIO,
                    Count = rec.Count,
                    Sum = rec.Sum,
                    ImplementerId = rec.ImplementerId,
                    ImplementerFIO = rec.Implementer.ImplementerFIO,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    ProductName = context.Products.FirstOrDefault(recS => recS.Id ==
                    rec.ProductId).ProductName,
                }).ToList();
            }
        }
    }
}

