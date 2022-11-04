using Market.Core.Application.Interfaces.Repositories;
using Market.Core.Domain.Entities;
using Market.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Persistence.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuarios>, IUsuariosRepository
    {
        private readonly ApplicationContext _applicationContext;

        public UsuarioRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<List<Usuarios>> GetAllExtensiveInclude()
        {
            return await _applicationContext
                .Set<Usuarios>()
                .Include(p => p.ArticulosUser)               
                .ToListAsync();
        }
    }
}
