using Market.Core.Application.ViewModels.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Usuarios
{
    public class UsuarioViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }

        //Propiedades de navegacion
        public List<ArticulosViewModel> ArticulosUser { get; set; }

    }
}
