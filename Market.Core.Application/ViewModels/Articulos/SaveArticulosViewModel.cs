using Market.Core.Application.ViewModels.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Articulos
{
    public class SaveArticulosViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar el nombre del articulo...")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe colocar la descripcion del articulo...")]
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Debe colocar el precio del articulo...")]
        public double Precio { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Debe colocar la categoria del articulo...")]
        public int CategoryID { get; set; }
        public int UsuarioID { get; set; }

        public List<CategoriaViewModel> CategoryList { get; set; }
    }
}
