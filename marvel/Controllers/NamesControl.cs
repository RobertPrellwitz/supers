using marvel.Data;
using marvel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marvel.Controllers
{
    public class NamesControl : Controller
    {
        // GET: NamesControl
        private ApplicationDbContext dbContext;

        public NamesControl(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: NamesControl/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NamesControl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NamesControl/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HerosList heros)
        {
            try
            {
                dbContext.heros.Add(heros);
                dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NamesControl/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NamesControl/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NamesControl/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NamesControl/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
