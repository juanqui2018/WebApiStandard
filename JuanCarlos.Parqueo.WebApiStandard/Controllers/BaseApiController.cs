using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Ninject;
using JuanCarlos.Parqueo.WebApiStandard.Infraestructure;
using JuanCarlos.Parqueo.Biz;

namespace JuanCarlos.Parqueo.WebApiStandard.Controllers
{
    public class BaseApiController : ApiController
    {
        private static IKernel kernel = new StandardKernel(new Infraestructure.DependencyResolver());

        protected CarManager CarManager = kernel.Get<CarManager>();
        protected CarParkManager CarParkManager = kernel.Get<CarParkManager>();
        protected ClientManager ClientManager = kernel.Get<ClientManager>();
        protected InputOutputCarManager InputOutputCarManager = kernel.Get<InputOutputCarManager>();
        protected ParkingManager ParkingManager = kernel.Get<ParkingManager>();
        protected SetMoneyManager SetMoneyManager = kernel.Get<SetMoneyManager>();
    }
}