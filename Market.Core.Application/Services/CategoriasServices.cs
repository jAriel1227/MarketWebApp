using AutoMapper;
using Market.Core.Application.Interfaces.Repositories;
using Market.Core.Application.Interfaces.Services;
using Market.Core.Application.ViewModels.Categorias;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Services
{
    public class CategoriasServices : GenericServices<SaveCategoriaViewModel, CategoriaViewModel, Categorias>, ICategoriasServices
    {
        private readonly ICategoriasRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriasServices(ICategoriasRepository categoriasRepository, IMapper mapper) : base(categoriasRepository, mapper)
        {
            _categoriaRepository = categoriasRepository;
            _mapper = mapper;
        }
        public async Task<List<CategoriaViewModel>> GetAllViewModelWithInclude()
        {
            var aList = await _categoriaRepository.GetAllExtensiveInclude();

            return _mapper.Map<List<CategoriaViewModel>>(aList);
        }
    }
}
