using AirPlaneFactoryBusinessLogic.BindingModels;
using AirPlaneFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;


namespace AirPlaneFactoryBusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductBindingModel model);
        void CreateOrUpdate(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}
