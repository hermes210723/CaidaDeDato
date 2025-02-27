using Microsoft.AspNetCore.Mvc;
using CaidaDeDato.Models;

namespace CaidaDeDato.Controllers
{
    public class DatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double altura)
        {
            if (altura <= 0)
            {
                ModelState.AddModelError("", "La altura debe ser mayor a 0");
                return View("Index");
            }

            var dato = new DatoModel { Altura = altura };
            dato.CalcularCaida();

            return View("Resultado", dato);  // Asegurar que enviamos el modelo
        }
    }
}
