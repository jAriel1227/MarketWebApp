using Market.Core.Application.ViewModels.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Categorias
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int CountArti { get; set; }
        public int UserQuantity { get; set; }
        //Propiedades de navegacion
        public List<ArticulosViewModel> CategoryArti { get; set; }
    }
}
