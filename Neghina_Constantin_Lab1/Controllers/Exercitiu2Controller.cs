using Microsoft.AspNetCore.Mvc;

namespace Neghina_Constantin_Lab1.Controllers
{
    public class Exercitiu2Controller : Controller
    {
        public IActionResult Date()
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now; 
            return View();
        }
    }
}
