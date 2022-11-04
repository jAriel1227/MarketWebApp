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
    public class CategoriaRepository : GenericRepository<Categorias>, ICategoriasRepository 
    { 
        private readonly ApplicationContext _applicationContext;

        public CategoriaRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<List<Categorias>> GetAllExtensiveInclude()
        {
            return await _applicationContext
                .Set<Categorias>()
                .Include(p => p.CategoriaArti)                
                .ToListAsync();
        }
    }
}
