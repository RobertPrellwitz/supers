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
    public class NamesController : Controller
    {
        // GET: NamesControl
        private ApplicationDbContext dbContext;

        public NamesController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public ActionResult Index()
        {
            var superheroes = dbContext.heros.Select(h => h);

            //var heroes = dbContext.heros.ToList();
            return View(superheroes);
        }

        // GET: NamesControl/Details/5
        public ActionResult Details(int Id)
        {
            dbContext.heros.Find(Id);

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
        public ActionResult Create(HerosList hero)
        {
            try
            {
                dbContext.heros.Add(hero);
                dbContext.SaveChanges();

                //return RedirectToAction("Index", "Home");
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
            var returnHero = dbContext.heros.Find(id);
            return View(returnHero);
        }

        // POST: NamesControl/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, HerosList hero)
        {
            try
            {
                dbContext.heros.Update(hero);
                dbContext.SaveChanges();
                
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
