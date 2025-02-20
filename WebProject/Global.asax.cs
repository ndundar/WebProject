﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityMvc5.Start();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
