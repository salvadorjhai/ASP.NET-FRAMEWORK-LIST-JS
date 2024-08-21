using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var s = FormsAuthentication.Decrypt("75EE059188E56C66C74248F664C59CF01867877376A1FD099BDE4127FA118FE7AC68C7CD2CE4A9C8490160380BADB49DC3C5054F7E5DBC1F2C30898A45EFDB8676ADCB0FF9EAD30FD3DAD37DEB45041D");
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

        public ActionResult Requirements()
        {
            ViewBag.Message = "Requirements";
            return View();
        }
    }
}