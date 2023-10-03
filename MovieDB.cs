using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movie_database_MVC
{
    public class MovieDB : Controller
    {
        // GET: MovieDB
        public ActionResult Index()
        {
            return View();
        }

        // GET: MovieDB/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieDB/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieDB/Create
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

        // GET: MovieDB/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieDB/Edit/5
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

        // GET: MovieDB/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieDB/Delete/5
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
