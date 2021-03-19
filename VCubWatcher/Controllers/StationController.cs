using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using VCubWatcher.Models;

namespace VCubWatcher.Controllers
{
    public class StationController : Controller
    {
        public static List<Station> StationsList = new List<Station>();

        // GET: StationController
        public StationController()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://api.alexandredubois.com/vcub-backend/vcub.php").Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;
                        StationsList = JsonConvert.DeserializeObject<List<Station>>(json);
                    }
                }
            }
        }
        public ActionResult Index()
        {
            return View(StationsList);
        }

        public IActionResult Map()
        {
            return View(StationsList);
        }

        public IActionResult Favorites()
        {
            return View(StationsList);
        }

        // GET: StationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StationController/Create
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

        // GET: StationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StationController/Edit/5
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

        // GET: StationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StationController/Delete/5
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
