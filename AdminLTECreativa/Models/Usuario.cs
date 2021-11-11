using System;
using System.Collections.Generic;

#nullable disable

namespace AdminLTECreativa.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Userr { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }
        public char? Rol { get; set; }
        public string Tokenrecovery { get; set; }
    }
}
