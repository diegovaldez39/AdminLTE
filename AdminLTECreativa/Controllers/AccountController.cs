using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using AdminLTECreativa.Conexion;
using AdminLTECreativa.Models;
using System.Linq;

namespace AdminLTECreativa.Controllers
{
    public class AccountController : Controller
    {
        ConexionBD obj = new ConexionBD();
        Funciones obj1 = new Funciones();
        
        private creativaContext Context { get; set; }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (obj1.Login(username, password) == 1)
            {
                //usuario
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }
            else if (obj1.Login(username, password) == 2)
            {
                //administrador
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("IndexAdmin", "Home");
            }
            else
            {
                ViewBag.error = "Credenciales incorrectas";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult Forgot(string username, string password, string repassword)
        {
            if (!string.IsNullOrEmpty(username))
            {
                obj1.ActualizarPassword(username, password);
                return View("Views/Home/Index.cshtml");
            }
            else
            {
                ViewBag.error = "No se encuentra el usuario";
                return View("Views/Home/Forgot.cshtml");
            }
        }
        public IActionResult Register(string name, string lastname, string userr, string email, string password, string repassword, string rol)
        {
            if (obj1.Registrar(name, lastname, userr, email, password, repassword, rol) == 0)
            {
                ViewBag.error = "Usuario ya existe";
                return View();
            }
            else
            {
                return View("Views/Home/Index.cshtml");
            }
        }
        [HttpGet]
        public IActionResult StarRecovery()
        {
            Models.ViewModel.RecoveryViewModel model = new Models.ViewModel.RecoveryViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult StarRecovery(Models.ViewModel.RecoveryViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                string token = Encrypt.GetSHA256(Guid.NewGuid().ToString());

                using (Models.creativaContext db = new creativaContext())
                {
                    var oUser = db.Usuarios.Where(d => d.Email == model.Email).FirstOrDefault();
                    if (oUser != null)
                    {
                        oUser.Tokenrecovery = token;
                        db.Entry(oUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        db.SaveChanges();

                        Encrypt.SendEmail(oUser.Email, token);
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }
        [HttpGet]
        public IActionResult Recovery(string token)
        {
            Models.ViewModel.RecoveryPasswordViewModel model = new Models.ViewModel.RecoveryPasswordViewModel();
            model.token = token;
            using (Models.creativaContext db = new creativaContext())
            {
                if (model.token==null || model.token.Trim().Equals(""))
                {
                    return View("Login");
                }
                var oUser = db.Usuarios.Where(d => d.Tokenrecovery == model.token).FirstOrDefault();
                if (oUser == null)
                {
                    ViewBag.Error = "Token invalido! ez";
                    return View("Login");
                }
            }

            
            return View();
        }
        [HttpPost]
        public IActionResult Recovery(Models.ViewModel.RecoveryPasswordViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                using(Models.creativaContext db= new creativaContext())
                {
                    var oUser = db.Usuarios.Where(x => x.Tokenrecovery == model.token).FirstOrDefault();
                    if (oUser != null)
                    {
                        oUser.Password = model.Password;
                        oUser.Tokenrecovery = null;
                        db.Entry(oUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        db.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            ViewBag.Message = "Contraseña modificada con exito";
            return View("Login");
        }
        #region HELPERS

        #endregion
    }
}
