using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Core.Application.ViewModels.Usuarios
{
    public class LoginUsersViewModel
    {
        [Required(ErrorMessage = "Usuario incorrecto!")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Contraseña incorrecta!")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
       
    }
}
