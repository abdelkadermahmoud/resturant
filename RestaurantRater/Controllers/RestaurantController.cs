using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantRater.Models;

namespace RestaurantRater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext db = new RestaurantDBContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Resturants.ToList());
        }
    }
}