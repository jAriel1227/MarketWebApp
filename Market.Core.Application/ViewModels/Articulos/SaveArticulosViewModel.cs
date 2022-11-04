using Market.Core.Application.ViewModels.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Articulos
{
    public class SaveArticulosViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoryID { get; set; }
        public int UsuarioID { get; set; }

        public List<CategoriaViewModel> CategoryList { get; set; }
    }
}
