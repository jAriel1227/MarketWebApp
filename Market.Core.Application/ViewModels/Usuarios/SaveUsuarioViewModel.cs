using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Usuarios
{
    public class SaveUsuarioViewModel
    {
        [Required(ErrorMessage = "Debe colocar su nombre de usuario...")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Debe colocar su Email...")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe colocar su contraseña...")]
        [DataType(DataType.Text)]
        public string Contrasena { get; set; }
        [Required(ErrorMessage = "Debe confirmar su contrseña...")]
        [DataType(DataType.Text)]
        public string ConfirPass { get; set; }
        [Required(ErrorMessage = "Debe colocar su Nombre...")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe colocar su Apellido...")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe colocar su numero de telefono...")]
        [DataType(DataType.Text)]
        public string Telephone { get; set; }
    }
}
