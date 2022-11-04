using Market.Core.Application.ViewModels.Articulos;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Interfaces.Services
{
    public interface IArticulosServices : IGenericServices<SaveArticulosViewModel,
        ArticulosViewModel, Articulos>
    {
       Task<List<ArticulosViewModel>> GetAllViewModelWithInclude();
    }
}
