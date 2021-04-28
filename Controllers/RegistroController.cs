using Microsoft.AspNetCore.Mvc;
using PC2_Progra.Models;

namespace PC2_Progra.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult Registro(){
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Usuario u){
            if (ModelState.IsValid){
                return RedirectToAction("Registrados");
            }
            return View();
        }
        public IActionResult Registrados(){
            return View();
        }
    }
}