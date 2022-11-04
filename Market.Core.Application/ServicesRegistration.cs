using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Market.Core.Application
{
    public static class ServicesRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            //Hacer el inyection del Automapper
            #region Automapp
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #endregion

            #region Servicios
            services.AddTransient<IArticulosServices, ArticulosServices>();
            services.AddTransient<ICategoriasServices, CategoriasServices>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();
            services.AddTransient<IGaleriaServices, GaleriaServices>();
            #endregion*/
        }
    }
}
