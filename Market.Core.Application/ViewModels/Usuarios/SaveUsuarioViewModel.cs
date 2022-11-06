using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Usuarios
{
    public class SaveUsuarioViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string ConfirPass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telephone { get; set; }
    }
}
