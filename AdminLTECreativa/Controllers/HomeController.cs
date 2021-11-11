using AdminLTECreativa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTECreativa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private creativaContext Context { get; set; }
        List<Solicitude> solicitudes = new List<Solicitude>();

        public HomeController(ILogger<HomeController> logger, creativaContext context)
        {
            _logger = logger;
            this.Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexAdmin()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Forgot()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Formularios()
        {
            return View();
        }
        public IActionResult SolicitudeBonif()
        {
            var VerSolicitudes = from B in this.Context.Solicitudes where B.Estado == "Pendiente" select B;

            if (VerSolicitudes.Any())
            {
                foreach (var S in VerSolicitudes)
                {
                    solicitudes.Add(S);
                }
            }

            return View(solicitudes);
        }
        [HttpGet]
        public IActionResult VerBonif(int id) 
        {
            var VerBonificacion = (from B in Context.Solicitudes where B.Id == id select B).FirstOrDefault();

            if (VerBonificacion != null)
            {
                return View(VerBonificacion);
            }
            else
            {
                return RedirectToAction("SolicitudeBonif", "Home");
            }
        }
        public IActionResult AceptarBonif(int id)
        {
            using (Context)
            {
                var AceptarBonif = Context.Solicitudes.Where(x => x.Id == id).SingleOrDefault();

                if (AceptarBonif != null)
                {
                    AceptarBonif.Estado = "Aceptado";
                    AceptarBonif.Fechaaprob = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    Context.Entry(AceptarBonif).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Context.SaveChanges();
                }
            }
            return RedirectToAction("SolicitudeBonif", "Home");
        }
        public IActionResult BorrarBonif(int id)
        {
            using (Context)
            {
                var AceptarBonif = Context.Solicitudes.Where(x => x.Id == id).SingleOrDefault();

                if (AceptarBonif != null)
                {
                    AceptarBonif.Estado = "Borrado";
                    AceptarBonif.Fechaborrado = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    Context.Entry(AceptarBonif).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Context.SaveChanges();
                }
            }
            return RedirectToAction("SolicitudeBonif", "Home");
        }

        public IActionResult SolicitudesAprob() 
        {
            var VerAceptados = from B in this.Context.Solicitudes where B.Estado == "Aceptado" select B;

            if (VerAceptados.Any())
            {
                foreach (var S in VerAceptados)
                {
                    solicitudes.Add(S);
                }
            }

            return View(solicitudes);
        }
    }
}
