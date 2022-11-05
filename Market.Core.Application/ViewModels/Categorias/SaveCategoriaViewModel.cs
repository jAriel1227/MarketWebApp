using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.ViewModels.Categorias
{
    public class SaveCategoriaViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre de la categoria...")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
