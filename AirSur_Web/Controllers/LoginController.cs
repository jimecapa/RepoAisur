using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AirSur_Web.Controllers
{
    public class LoginController : Controller
    {



        public ActionResult Index(bool? login)
        {
            if (login == true)
            {
                login = null;
                return View();

            }
            return RedirectToAction("Login");
        }

        public string LoginUsuario(string user, string password)
        {
            var usuario = (from u in baseDatos.Login
                           where u.Usuario.Equals(user) && u.Password.Equals(password)
                           select u);


            if (usuario != null && usuario.Any())
            {
                FormsAuthentication.SetAuthCookie(usuario.FirstOrDefault().Usuario, false);
                ViewBag.username = usuario.Select(x => x.Usuario);
                return Newtonsoft.Json.JsonConvert.SerializeObject(usuario);
            }
            else
                return null;
        }



        public string Logout()
        {
            FormsAuthentication.SignOut();
            return Newtonsoft.Json.JsonConvert.SerializeObject("Sesión cerrada con éxito");
        }


        public ActionResult Login()
        {
            return View();
        }




    }
}