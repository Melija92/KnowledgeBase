using KnowledgeBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KnowledgeBase
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
             
            foreach (Route r in RouteTable.Routes)
            {
                if (r.Defaults != null)
                {
                    if (r.Defaults.Values.Count > 0)
                    {
                        var routeList = r.Defaults.ToList();
                        Routes.Controller = Convert.ToString(routeList[0].Value);
                        Routes.ActionMethod = Convert.ToString(routeList[1].Value);
                    }
                }
            }
        } 
    }
}
