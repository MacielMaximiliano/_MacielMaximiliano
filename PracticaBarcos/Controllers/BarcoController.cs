using Microsoft.AspNetCore.Mvc;
using PracticaBarcos.Models;
using PracticaBarcosLogica;

namespace PracticaBarcos.Controllers
{


    public class BarcoController : Controller
    {
        private readonly IBarcoLogica _barcoLogica;

        public BarcoController(IBarcoLogica barcoLogica)
        {
            _barcoLogica = barcoLogica;
        }


        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Listado()
        {


            var Barco = _barcoLogica.Listado();

            return View(BarcoViewModel.AListaModel(Barco));

        }
        [HttpPost]
        public IActionResult RegistrarBarco(Models.BarcoViewModel barcoModel)
        {

            if (!ModelState.IsValid)
            {
                return View(barcoModel);
            }

            _barcoLogica.AgregarBarco(BarcoViewModel.aBarco(barcoModel));

            return RedirectToAction("Listado");
        }
    }
    

}
