using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTECreativa.Models.ViewModel
{
    public class RecoveryViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese su email")]
        public string Email { get; set; }
    }
}
