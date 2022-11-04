using AutoMapper;
using Market.Core.Application.Interfaces.Repositories;
using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Galeria;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Services
{
    public class GaleriaServices : GenericServices<SaveGaleriaViewModel, GaleriaViewModel, Galeria>, IGaleriaServices
    {
        private readonly IGaleriaRepository _galeriaRepository;
        private readonly IMapper _mapper;

        public GaleriaServices(IGaleriaRepository galeriaRepository, IMapper mapper) : base(galeriaRepository, mapper)
        {
            _galeriaRepository = galeriaRepository;
            _mapper = mapper;
        }
        public async Task<List<GaleriaViewModel>> GetAllViewModelWithInclude()
        {
            var aList = await _galeriaRepository.GetAllExtensiveInclude();

            return _mapper.Map<List<GaleriaViewModel>>(aList);
        }
    }
}
