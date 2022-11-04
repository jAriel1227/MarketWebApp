using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Galeria
{
    public class SaveGaleriaViewModel
    {
        public int IdGaleria { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public int ArticuloId { get; set; }
    }
}
