using AutoMapper;
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
using System.Web;

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
             // Mapper.CreateMap<Car, CarViewModel>().ReverseMap();
            /*  CreateMap<QueryResult<UserSummary>, UserResultResourceList>()
               .ForMember(x => x.Items, opts => opts.MapFrom(x => x.Items));
               */
           Mapper.Initialize(cfg => cfg.CreateMap<Car, CarViewModel>());
            //or
          //  var config = new MapperConfiguration(cfg => cfg.CreateMap<Car, CarViewModel>());
        }
    }
}
