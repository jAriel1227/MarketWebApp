using Market.Core.Application.ViewModels.Usuarios;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Interfaces.Services
{
    public interface IUsuariosServices : IGenericServices<SaveUsuarioViewModel, 
        UsuarioViewModel, Usuarios>
    {
        Task<List<UsuarioViewModel>> GetAllViewModelWithInclude();
    }
}
