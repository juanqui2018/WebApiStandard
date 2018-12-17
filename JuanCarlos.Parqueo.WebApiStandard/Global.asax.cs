﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using JuanCarlos.Parqueo.WebApiStandard.Models;
using JuanCarlos.Parqueo.Entities;


namespace JuanCarlos.Parqueo.WebApiStandard
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Configure();
        }
        private void Configure()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Car, CarViewModel>();
                cfg.CreateMap<CarPark, CarParkViewModel>();
                cfg.CreateMap<Client, ClientViewModel>();
                cfg.CreateMap<InputOutputCar, InputOutputCarViewModel>();
                cfg.CreateMap<Parking, ParkingViewModel>();
                cfg.CreateMap<SetMoney, SetMoneyViewModel>();
            });

            config.CreateMapper();
        }
    }
}
