using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Interfaces.Repositories
{
    public interface ICategoriasRepository : IGenericRepository<Categorias>
    {
        Task<List<Categorias>> GetAllExtensiveInclude();
    }
}
