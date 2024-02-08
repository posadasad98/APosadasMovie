using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class ProductoController : Controller
    {
        public ActionResult Catalogo()
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
