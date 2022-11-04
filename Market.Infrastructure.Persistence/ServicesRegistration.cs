using Market.Core.Application.Interfaces.Repositories;
using Market.Infrastructure.Persistence.Context;
using Market.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Contextos
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("DBAplication"));
            }
            else
            {
                services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBConnection"),
                j => j.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }
            #endregion

            #region Repositorios
              services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
              services.AddTransient<IArticulosRepository, ArticulosRepository>();
              services.AddTransient<IUsuariosRepository, UsuarioRepository>();
              services.AddTransient<ICategoriasRepository, CategoriaRepository>();
              services.AddTransient<IGaleriaRepository, GaleriaRepository>();
            #endregion
        }
    }
}
