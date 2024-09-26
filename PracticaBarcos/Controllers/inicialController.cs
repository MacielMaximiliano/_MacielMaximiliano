using Microsoft.AspNetCore.Mvc;

namespace PracticaBarcos.Controllers
{
    public class InicialController : Controller
    {
        public IActionResult Bienvenida()
        {
            return View();
        }
    }
}
