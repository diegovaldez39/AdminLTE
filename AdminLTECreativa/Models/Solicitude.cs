using System;
using System.Collections.Generic;

#nullable disable

namespace AdminLTECreativa.Models
{
    public partial class Solicitude
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime? Fecha { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Dui { get; set; }
        public string Cargo { get; set; }
        public string Mes { get; set; }
        public string Mesdesc { get; set; }
        public string Tiposolicitud { get; set; }
        public string Estado { get; set; }
        public string Fechaaprob { get; set; }
        public string Fechaborrado { get; set; }
    }
}
