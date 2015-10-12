using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestCheesesteaks.Web.Controllers
{
  public class ShopController : Controller
  {
    // GET: Shop
    public ActionResult Index()
    {
      return Redirect("/default.html");
    }

    public ActionResult Search()
    {

      var ctx = new Models.ShopContext();

      return View(ctx.Shops.OrderByDescending(s => s.Rating).ToList());

    }

  }
}