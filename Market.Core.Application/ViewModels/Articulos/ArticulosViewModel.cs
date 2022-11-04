using Market.Core.Application.ViewModels.Categorias;
using Market.Core.Application.ViewModels.Galeria;
using Market.Core.Application.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Articulos
{
    public class ArticulosViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        //Propiedades de navegacion
        public int CategoriaID { get; set; }
        public CategoriaViewModel Categorias { get; set; }
        public int UsuarioID { get; set; }
        public UsuarioViewModel Usuario { get; set; }
        public List<GaleriaViewModel> Gallery { get; set; }
    }
}
