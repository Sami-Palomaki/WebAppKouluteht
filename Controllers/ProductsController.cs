using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTietokantasovellus.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("login", "home");
            }
            else
            {
                NorthwindEntities db = new NorthwindEntities();
                List<Products> model = db.Products.ToList();
                db.Dispose();
                return View(model);
            }
        }
    }
}