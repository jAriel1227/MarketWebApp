using Market.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Domain.Entities
{
    public class Articulos : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        //Propiedades de navegacion
        public int CategoriaID { get; set; }
        public Categorias Categorias { get; set; }
        public int UsuarioID { get; set; }
        public Usuarios Usuario { get; set; }
        public ICollection<Galeria> Galeria { get; set; }
    }
}
