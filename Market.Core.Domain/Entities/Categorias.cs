using Market.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Domain.Entities
{
    public class Categorias : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Propiedades de navegacion
        public ICollection<Articulos> CategoriaArti { get; set; }
    }
}
