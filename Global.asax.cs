using BetterCms.Core;
using BetterCms.Core.Environment.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;

//using BetterCms.Module.Api;
//using BetterCms.Module.Api.Infrastructure;
//using BetterCms.Module.Api.Infrastructure.Enums;
//using BetterCms.Module.Api.Operations.Pages.Widgets;

namespace TSV
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        private static ICmsHost cmsHost;

        protected void Application_Start()
        {
            cmsHost = CmsContext.RegisterHost();

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            cmsHost.OnApplicationStart(this);
        }


        protected void Application_BeginRequest()
        {
            // [YOUR CODE]

            cmsHost.OnBeginRequest(this);
        }

        protected void Application_EndRequest()
        {
            // [YOUR CODE]

            cmsHost.OnEndRequest(this);
        }

        protected void Application_Error()
        {
            // [YOUR CODE]

            cmsHost.OnApplicationError(this);
        }

        protected void Application_End()
        {
            // [YOUR CODE]

            cmsHost.OnApplicationEnd(this);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            var roles = new[] { "BcmsEditContent",
            "BcmsPublishContent", "BcmsDeleteContent", "BcmsAdministration"};

            var principal = new GenericPrincipal(new GenericIdentity("TestUser"), roles);
            HttpContext.Current.User = principal;

            cmsHost.OnAuthenticateRequest(this);
        }
    }
}