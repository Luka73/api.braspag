using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using Project.Api.Mapping;

namespace Project.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(cfg => { cfg.AddProfile<AutoMapperConfig>(); });
        }
    }
}
