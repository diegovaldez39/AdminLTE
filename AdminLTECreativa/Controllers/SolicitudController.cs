using AdminLTECreativa.Conexion;
using AdminLTECreativa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTECreativa.Controllers
{
    public class SolicitudController : Controller
    {
        readonly FuncionesBonif obj1 = new FuncionesBonif();
        public IActionResult Bonificacion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Bonificacion(string email, DateTime fecha, string name, string lastname, string dui, string cargo, string mes)
        {
            obj1.RegistrarBonificacion(email, fecha, name, lastname, dui, cargo, mes);
            return View();
        }
        public IActionResult HExtras()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HExtras(string email, DateTime fecha, string name, string lastname, string dui, string cargo, string mes)
        {
            obj1.RegistrarHorasE(email, fecha, name, lastname, dui, cargo, mes);
            return View();
        }
        public IActionResult AdelSalarial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdelSalarial(string email, DateTime fecha, string name, string lastname, string dui, string mes, string mesDesc)
        {
            obj1.RegistrarAdelSal(email, fecha, name, lastname, dui, mes, mesDesc);
            return View();
        }

        public IActionResult Succes()
        {
            return View();
        }
        public IActionResult Existe()
        {
            return View();
        }
    }
}
