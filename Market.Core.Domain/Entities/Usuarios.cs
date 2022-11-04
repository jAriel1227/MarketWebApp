using Market.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Domain.Entities
{
    public class Usuarios : AuditableBaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telephone { get; set; }

        //Propiedades de navegacion
        public ICollection<Articulos> ArticulosUser { get; set; }
    }
}
