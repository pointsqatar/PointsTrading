using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace PointsTrading
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            if (Application["NoOfUsers"] == null)
            {
                Application["NoOfUsers"] = 0;
            }
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            Application.Lock();
            Application["NoOfUsers"] = (int)Application["NoOfUsers"] + 1;
            Application.UnLock();
        }
    }
}
