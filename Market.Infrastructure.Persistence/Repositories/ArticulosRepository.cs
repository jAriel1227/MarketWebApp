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
    public class ArticulosRepository : GenericRepository<Articulos>, IArticulosRepository
    {
        private readonly ApplicationContext _applicationContext;

        public ArticulosRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }
        //utilizar los navigation properties....
        public async Task<List<Articulos>> GetAllExtensiveInclude()
        {
            return await _applicationContext
                .Set<Articulos>()
                .Include(p => p.Galeria)
                .Include(p => p.Usuario)
                .Include(p => p.Categorias)
                .ToListAsync();
        }
    }
}
