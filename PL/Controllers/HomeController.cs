using Microsoft.AspNetCore.Mvc;
using PL.Models;
using System.Diagnostics;

namespace PL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetAll()
        {
            Dictionary<string, object> resultado = BL.Producto.GetAll();
            bool correct = (bool)resultado["Resultado"];
            if (correct)
            {
                ML.Producto producto = (ML.Producto)resultado["Producto"];
                return View(producto);
            }
            return View();

        }
    }
}