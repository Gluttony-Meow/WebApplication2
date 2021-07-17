using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArrayList list = new ArrayList();

            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (CultureInfo culture in cinfo)
            {
                list.Add(String.Format("culture name{0} : Display name{1}", culture.Name, culture.DisplayName));
            }

            ViewBag.MyList = list; 

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}