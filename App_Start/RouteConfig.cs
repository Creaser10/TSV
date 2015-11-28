using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TSV
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            */
            routes.MapRoute("contacts-form", "contacts/submit-form", new { area = string.Empty, controller = "Contact", action = "ContactForm" }, new[] { "TSV.Controllers" });
            routes.MapRoute("menu-top", "menu/top", new { area = string.Empty, controller = "SiteMap", action = "Index" }, new[] { "TSV.Controllers" });
            routes.MapRoute("menu-sub", "menu/submenu/{parentUrl}", new { area = string.Empty, controller = "SiteMap", action = "SubMenu" }, new[] { "TSV.Controllers" });
            routes.MapRoute("blog-latest", "blog/latest/{categoryId}", new { area = string.Empty, controller = "Blog", action = "Index", categoryId = UrlParameter.Optional }, new[] { "TSV.Controllers" });
            routes.MapRoute("blog-last", "blog/last", new { area = string.Empty, controller = "Blog", action = "Last" }, new[] { "TSV.Controllers" });
            routes.MapRoute("blog-categories", "blog/categories", new { area = string.Empty, controller = "Blog", action = "GetCategories" }, new[] { "TSV.Controllers" });
            routes.MapRoute("blog-feed", "blog/feed", new { area = string.Empty, controller = "Blog", action = "Feed" }, new[] { "TSV.Controllers" });
        }
    }
}