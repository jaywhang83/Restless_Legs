using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Restless_Legs.Models;
using Microsoft.Data.Entity;


namespace Restless_Leg.Controllers
{
    public class LocationsController : Controller
    {
        private Restless_LegDbContext db = new Restless_LegDbContext();
        // GET: /<controller>/
        public IActionResult Index(string location)
        {
            Console.Write(location);
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.Name == location);
            //thisLocation.Postings = db.Postings.Where(p => p.LocationId == thisLocation.LocationId).Include(c => c.Comments).ToList();
            return View(thisLocation);
        }

        //public IActionResult Details(string location)
        //{
        //    Console.Write(location);
        //    var thisLocation = db.Locations.FirstOrDefault(locations => locations.Name.Contains(location));
        //    //thisLocation.Postings = db.Postings.Where(p => p.LocationId == thisLocation.LocationId).Include(c => c.Comments).ToList();
        //    return View(thisLocation); 
        //}

        public IActionResult Create()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }

        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation); 
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }


        public IActionResult Delete(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation); 
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            db.Locations.Remove(thisLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
