using FluentValidation.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiValidationDemo.Filters;
using WebApiValidationDemo.Handlers;

namespace WebApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new ValidateModelStateFilter());
            // config.Filters.Add(new StopwatchAttribute());
           // config.MessageHandlers.Add(new ResponseWrappingHandler());

     
            // Web API configuration and services
            FluentValidationModelValidatorProvider.Configure(config);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
