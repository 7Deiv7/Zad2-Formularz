using Formularz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
    public class DaneController : Controller
    {
        // GET: DaneController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DaneController/Details/5

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Rejestracja zakończona pomyślnie";
                return View("Wynik", dane);
            }
            else return View();

        }
        public IActionResult Wynik(Dane dane)
        {

            return View(dane);
        }

    }
}




