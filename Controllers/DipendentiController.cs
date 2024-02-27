using Microsoft.AspNetCore.Mvc;
using S5L1.Models;

namespace S5L1.Controllers
{
    public class DipendentiController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.GetAll());
        }

        public IActionResult Form()
        {
            return View();
        }

        //logica per gestire il submit del form
        [HttpPost]
        public IActionResult Add(string Nome, string Cognome, string CodiceFiscale, string Indirizzo, string StatoCivile, int FigliCarico, string Mansione)
        {
            var dipendente = StaticDB.Add(Nome, Cognome, CodiceFiscale, Indirizzo, StatoCivile, FigliCarico, Mansione);
            return RedirectToAction("Index", new { id = dipendente.Id });
        }

    }
}
