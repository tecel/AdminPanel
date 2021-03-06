﻿using System.Web.Mvc;

namespace AdminPanel.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{dil}/{controller}/{action}/{id}",
                new { dil = "tr",controller ="Home", action = "Index", id = UrlParameter.Optional },
                 namespaces: new[] { "AdminPanel.Areas.Admin.Controllers" }
            );
        }
    }
}