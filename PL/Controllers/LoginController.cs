using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {

            return View();
        }
        //[HttpPost]
        //public ActionResult Login(string Email, string password)
        //{
        //    Dictionary<string, object> diccionario = BL.Usuario.GetByEmail(Email);
        //    bool resultado = (bool)diccionario["Resultado"];
        //    if (resultado == true)//el metodo funciono
        //    {
        //        ML.Usuario usuario = (ML.Usuario)diccionario["Usuario"];
        //        if (usuario.Email != "")
        //        {
        //            if (usuario.Password == password)
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //        else
        //        {
        //            ViewBag.Mensaje = "El email no existe";
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        ViewBag.Mensaje = "El email no existe";
        //        return PartialView("Modal");
        //    }
        //    return View();

        //}
    }
}
