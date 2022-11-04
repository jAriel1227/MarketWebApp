using AutoMapper;
using Market.Core.Application.Interfaces.Repositories;
using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Articulos;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Services
{
    public class ArticulosServices : GenericServices<SaveArticulosViewModel, ArticulosViewModel, Articulos>, IArticulosServices
    {
        private readonly IArticulosRepository _articulosRepository;
        private readonly IMapper _mapper;

        public ArticulosServices(IArticulosRepository articulosRepository,
            IMapper mapper) : base(articulosRepository,mapper)
        {
            _articulosRepository = articulosRepository;
            _mapper = mapper;
        }
        public async Task<List<ArticulosViewModel>> GetAllViewModelWithInclude()
        {
            var aList = await _articulosRepository.GetAllExtensiveInclude();

            return _mapper.Map<List<ArticulosViewModel>>(aList);
        } 
    }
}
