using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Raven.Client.Document;


namespace ravenDB_3U2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static DocumentStore MyStore;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Create raven documentStore object one time only
            MyStore = new DocumentStore { Url = "http://localhost:8080" };
            MyStore.Initialize();
            // end Create	

        }
    }
}
