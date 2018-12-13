using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JuanCarlos.Parqueo.Contracts;
using JuanCarlos.Parqueo.EFContext;
using Ninject.Modules;

namespace JuanCarlos.Parqueo.WebApiStandard.Infraestructure
{
    public class DependencyResolver: NinjectModule
    {
        public override void Load()
        {
            Bind<ICarDao>().To<CarDao>();
            Bind<ICarParkDao>().To<CarParkDao>();
            Bind<IClientDao>().To<ClientDao>();
            Bind<IInputOutputCarDao>().To<InputOutputCarDao>();
            Bind<IParkingDao>().To<ParkingDao>();
            Bind<ISetMoneyDao>().To<SetMoneyDao>();
        }
    }
}