using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Restless_Legs.Models;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Restless_Leg.Controllers
{
    public class PostingsController : Controller
    {
        private Restless_LegDbContext db = new Restless_LegDbContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Details(int id)
        {
            var thisPosting = db.Postings.FirstOrDefault(postings => postings.PostingId == id);
            thisPosting.Comments = db.Comments.Where(x => x.PostingId == id).ToList();
            return View(thisPosting);
        }

        public IActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Posting posting)
        {
            db.Postings.Add(posting);
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        public IActionResult Edit(int id)
        {
            var thisPosting = db.Postings.FirstOrDefault(postings => postings.PostingId == id);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            return View(thisPosting);
        }

        [HttpPost]
        public IActionResult Edit(Posting posting)
        {
            db.Entry(posting).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }

        public IActionResult Delete(int id)
        {
            var thisPosting = db.Postings.FirstOrDefault(postings => postings.PostingId == id);
            return View(thisPosting);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPosting = db.Postings.FirstOrDefault(postings => postings.PostingId == id);
            db.Postings.Remove(thisPosting);
            db.SaveChanges();
            return RedirectToAction("Index", "Locations");
        }
    }
}
