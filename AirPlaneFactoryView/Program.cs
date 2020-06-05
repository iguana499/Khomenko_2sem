using AirPlaneFactoryBusinessLogic.BusnessLogics;
using AirPlaneFactoryBusinessLogic.Interfaces;
using AirPlaneFactoryDatabaseImplement.Impliments;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;


namespace AirPlaneFactoryView
{
    static class Program
   {
    [STAThread]
    static void Main()
    {
        var container = BuildUnityContainer();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(container.Resolve<FormMain>());
    }
    private static IUnityContainer BuildUnityContainer()
    {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentLogic, ComponentLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductLogic, ProductLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<MainLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientLogic, ClientLogic>(new
          HierarchicalLifetimeManager());
            return currentContainer;
    }
   }    
}
