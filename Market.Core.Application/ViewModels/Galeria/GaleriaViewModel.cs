using Market.Core.Application.ViewModels.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Galeria
{
    public class GaleriaViewModel
    {
        public int IdGaleria { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }

        //Propiedades de navegacion

        public int ArticuloId { get; set; }
        public ArticulosViewModel Articulos { get; set; }
    }
}
