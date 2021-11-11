using System.ComponentModel.DataAnnotations;

namespace AdminLTECreativa.Models.ViewModel
{
    public class RecoveryPasswordViewModel
    {
        public string token { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "La confirmacion de la contraseña es requerida")]
        [Compare("Password", ErrorMessage = "las contraseñas no coinciden")]
        public string rePassword { get; set; }
    }
}
