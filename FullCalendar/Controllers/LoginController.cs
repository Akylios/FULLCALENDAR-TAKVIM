using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullCalendar.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index2(string kullanici,string sifre)
        {
            if (kullanici=="admin" && sifre=="123456") { return Redirect("/Menu/Index"); }
            
            
            else { return Redirect("/Login/Index"); }

        }

    }
}
