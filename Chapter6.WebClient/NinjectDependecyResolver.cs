using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace Chapter6.WebClient
{
    public class NinjectDependecyResolver : IDependencyResolver
    {

        private IKernel _kernal;
        public NinjectDependecyResolver()
        {
            _kernal = new StandardKernel();
            AddBinding();
        }
        public object GetService(Type serviceType)
        {
            return _kernal.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernal.GetAll(serviceType);
        }

        private void AddBinding()
        {
            _kernal.Bind<Chapter6.Domain.Models.IValueCalculator>().To<Domain.Models.LinqValueCalculator>();
            _kernal.Bind<Chapter6.Domain.Models.IDiscountCalculator>().To<Domain.Models.DiscountCalculator>().WithPropertyValue("DiscountInPercentage", 80m);
        }
    }
}