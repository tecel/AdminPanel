using AdminPanel.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AdminPanel
{
    public class MvcApplication :  HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            Fonksiyonlar.CacheYukle();
        }
       
        protected void Application_PreRequestHandlerExecute()
        {
             try
            {
                tbl_Dil dil = Sabitler.GECERLI_DIL_FULL;
                
              
                
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(dil.CultureKod);

                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(dil.CultureKod);
              

            }
            catch
            {

                //Response.Redirect("~/splash/default", true);
            }
        }
    }
}
