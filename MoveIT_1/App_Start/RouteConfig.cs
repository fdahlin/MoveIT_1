﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MoveIT_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "routeOne",
                url: "routesDemo/One",
                defaults: new { controller = "RoutesDemo", action = "One" });

            routes.MapRoute(
                name: "routeTwo",
                url: "routesDemo/Two/{donuts}",
                defaults: new { controller = "RoutesDemo", action = "Two", donuts = UrlParameter.Optional });

            routes.MapRoute(
                name: "routeThree",
                url: "routesDemo/Three",
                defaults: new { controller = "RoutesDemo", action = "Three" });

            routes.MapRoute(
                name: "login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login" });

            routes.MapRoute(
                name: "register",
                url: "Account/Register",
                defaults: new { controller = "Account", action = "Register" });

            routes.MapRoute(
                name: "submit",
                url: "quotation/submit",
                defaults: new { controller = "Quotation", action = "Submit" });

            routes.MapRoute(
                name: "quotation",
                url: "quotation/Present/{id}",
                defaults: new { controller = "Quotation", action = "Present", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index" });
        }
    }
}
