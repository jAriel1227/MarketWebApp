using AutoMapper;
using Market.Core.Application.Interfaces.Repositories;
using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Usuarios;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Services
{
    public class UsuariosServices : GenericServices<SaveUsuarioViewModel, UsuarioViewModel, Usuarios>, IUsuariosServices
    {
        private readonly IUsuariosRepository _userRepository;
        private readonly IMapper _mapper;

        public UsuariosServices(IUsuariosRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UsuarioViewModel>> GetAllViewModelWithInclude()
        {
            var aList = await _userRepository.GetAllExtensiveInclude();

            return _mapper.Map<List<UsuarioViewModel>>(aList);
        }
    }
}
