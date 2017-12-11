using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using MVCSportsStorePractice.Domain.Abstract;
using MVCSportsStorePractice.Domain.Concrete;

namespace MVCSportsStorePractice.WebUI.Infrastructure
{
    public class NinjectCustomController : DefaultControllerFactory
    {
        private IKernel _kernal;


        public NinjectCustomController()
        {
            _kernal = new Ninject.StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernal.Get(controllerType);
        }

        public void AddBindings()
        {
            _kernal.Bind<IProductRespository>().To<ProductRepository>();
        }

    }
}