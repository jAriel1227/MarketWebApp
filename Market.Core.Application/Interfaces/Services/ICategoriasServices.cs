using Market.Core.Application.ViewModels.Categorias;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Interfaces.Services
{
    public interface ICategoriasServices : IGenericServices<SaveCategoriaViewModel,
        CategoriaViewModel, Categorias>
    {
        Task<List<CategoriaViewModel>> GetAllViewModelWithInclude();
    }
}
