using Market.Core.Application.Helpers;
using Market.Core.Application.ViewModels.Usuarios;
using Microsoft.AspNetCore.Http;

namespace Market.Middlewares
{
    public class ValidateUserSession
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ValidateUserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            UsuarioViewModel userViewModel = _httpContextAccessor.HttpContext.Session.Get<UsuarioViewModel>("user");

            if (userViewModel == null)
            {
                return false;
            }
            return true;
        }

    }
}
