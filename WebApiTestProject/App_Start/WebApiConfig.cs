using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiTestProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Routes.MapHttpRoute(
            //    name: "GetProductsByStringVal",
            //    routeTemplate: "api/{controller}/{val}",
            //    defaults: new { controller = "Products", action = "Get" }
            //);

            config.Formatters.JsonFormatter.SerializerSettings.Culture = new System.Globalization.CultureInfo("en-GB");            
        }
    }
}
