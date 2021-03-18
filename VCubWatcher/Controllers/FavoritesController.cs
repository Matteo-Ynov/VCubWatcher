using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCubWatcher.Controllers
{
    public class FavoritesController : Controller
    {
        // GET: FavoritesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FavoritesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FavoritesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavoritesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: FavoritesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FavoritesController/Edit/5
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

        // GET: FavoritesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FavoritesController/Delete/5
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
