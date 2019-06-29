using Bussiness;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteLaptop.Controllers
{
    public class HomeController : Controller
    {
        ProductBLL productBLL;
        public HomeController()
        {
            productBLL = new ProductBLL();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(productBLL.getProductByID("ASU001"));
        }
    }
}