using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PointsTrading
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //int noOfUsers = 0;

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Application["NoOfUsers"] = noOfUsers++;
        }
    }
}
