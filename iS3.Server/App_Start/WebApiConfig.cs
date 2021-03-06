﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;

using iS3.Server.Filters;

namespace iS3.Server
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

            // Filter Config
            config.Filters.Add(new ResponseFilterAttribute());
            config.Filters.Add(new ApiErrorHandleAttribute());

            // json indent
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            // xml indent
            var xml = config.Formatters.XmlFormatter;
            xml.Indent = true;
        }
    }
}
