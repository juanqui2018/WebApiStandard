using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Ninject;
//using Ninject.IIKernel;
using JuanCarlos.Parqueo.WebApiStandard.Infraestructure;
using JuanCarlos.Parqueo.Biz;

namespace JuanCarlos.Parqueo.WebApiStandard.Controllers
{
    public class BaseApiController : ApiController
    {
        private static IKernel kernel = new StandardKernel(new Infraestructure.DependencyResolver());

        protected CarManager CarManager = kernel.Get<CarManager>();
        //protected EventManager EventManager = kernel.Get<EventManager>();
        //protected UnitEducativeManager UnitEducativeManager = kernel.Get<UnitEducativeManager>();
    }
}