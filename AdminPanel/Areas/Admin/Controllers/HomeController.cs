using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
namespace AdminPanel.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
 
            return View();
        }

        //public ActionResult DilDegistir(string dil,string eskiDil, string returnUrl)
        //{

        //    returnUrl = returnUrl.Replace(("/"+eskiDil+"/"), ("/" + dil + "/"));
            
        //    return Redirect(returnUrl);
        //}

    }
}