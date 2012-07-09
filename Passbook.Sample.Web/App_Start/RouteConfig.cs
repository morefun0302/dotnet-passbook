﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Passbook.Sample.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ///api/v1/devices/d754ba022bd37181fed36ead4e7cf5d8/registrations/pass.tomasmcguinness.com
            routes.MapHttpRoute(
             name: "PassFetchUpdatedPasses",
             routeTemplate: "api/{version}/devices/{deviceLibraryIdentifier}/registrations/{passTypeIdentifier}",
             defaults: new { Controller = "PassRegistration" }
            );
            //https://webServiceURL/version/devices/deviceLibraryIdentifier/registrations/passTypeIdentifier/serialNumber

            routes.MapHttpRoute(
                name: "Registration",
                routeTemplate: "{version}/devices/{deviceLibraryIdentifier}/registrations/{passTypeIdentifier}{serialNumber}",
                defaults: new { Controller = "Registration" });

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}