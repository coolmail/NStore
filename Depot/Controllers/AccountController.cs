using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Depot.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login()
        {
            // System.Web.Security.FormsAuthentication.SignOut();
            /*
            string cultureCode = "bg";

            //Default Language/Culture for all number, Date format  
            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.CreateSpecificCulture("en");

            //Ui Culture for Localized text in the UI  
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo(cultureCode);   
            */
            return View();
        }

        //
        // GET: /Account/LogOff
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            // Затрива сесията
            Session.RemoveAll();
            // Затрива Cookie на IIS
            FormsAuthentication.SignOut();

            return Redirect("~/");
        }
    }
}
