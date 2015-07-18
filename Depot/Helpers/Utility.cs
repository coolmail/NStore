using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Depot.Helpers
{
    public static class Utility
    {
        /// <summary>  
        /// Set the culture based on culture code and set the   
        /// value in cookie  
        /// </summary>  
        /// <param name="cultureCode"></param>  
        public static void SetCulture(string cultureCode)
        {
            var cookieCultureLanguage = new HttpCookie("UserLanguage")
            {
                Value = cultureCode
            };
            HttpContext.Current.Response.Cookies.Set(cookieCultureLanguage);

            //Sets  Culture for Current thread  
            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.CreateSpecificCulture("en");

            //Ui Culture for Localized text in the UI  
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo(cultureCode);

        }  
    }
}