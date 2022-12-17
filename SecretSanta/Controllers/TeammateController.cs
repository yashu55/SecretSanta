using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SecretSanta.Controllers
{
    public class TeammateController : Controller
    {
        // GET: TeammateController
        public TeammateController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: TeammateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeammateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeammateController/Create
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

        // GET: TeammateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeammateController/Edit/5
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

        // GET: TeammateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeammateController/Delete/5
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
