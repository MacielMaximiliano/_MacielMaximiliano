using Microsoft.AspNetCore.Mvc;

namespace PracticaBarcos.Controllers
{
    public class inicioController : Controller
    {
        public IActionResult Bienvenida()
        {
            return View();
        }
    }
}
