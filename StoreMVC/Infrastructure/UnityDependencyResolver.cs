using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Moq;
using StoreMVC.Domain.Abstract;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Infrastructure
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(
                new List<Product>
                {
                    new Product() {Name = "Football", Price = 25},
                    new Product() {Name = "Surf board", Price = 179},
                    new Product() {Name = "Runnig shoes", Price = 95}
                });
            _container.RegisterType<IProductRepository>().RegisterInstance(mock.Object);
        }


    }
}