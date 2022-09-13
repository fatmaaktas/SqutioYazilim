﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SqutioYzlm
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected void Application_BeginRequest()
        //{
        //    if (!Request.IsSecureConnection)
        //    {
        //        string path = string.Format("https{0}", Request.Url.AbsoluteUri.Substring(4));

        //        Response.Redirect(path);
        //    }
        //}
    }
}
