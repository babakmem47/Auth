using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Auth.ViewModel;

namespace Auth.Controllers
{
    public class PersonController : Controller
    {
        private readonly AuthDbEntities _db;

        public PersonController()
        {
            _db = new AuthDbEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

        // GET: Person
        public ActionResult Index()
        {
            var personsList = _db.Persons.Include(s => s.Semat).ToList();
            return View(personsList);
        }
    }
}