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

            //Here return the view and find it at db Resturants then make it a list
            return View(db.Resturants.ToList());
        }
        //GET: Resturant/Create
        //Create() calls create view page
        public ActionResult Create()
        {
            //return View() - show view
            return View();
        }

        //POST: Resturant to our db
        //passes data from forms 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResturantID,Name")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Resturants.Add(restaurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }
    }

   
}