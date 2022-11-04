using Market.Core.Application.ViewModels.Galeria;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Interfaces.Services
{
    public interface IGaleriaServices : IGenericServices<SaveGaleriaViewModel,
        GaleriaViewModel, Galeria>
    {
        Task<List<GaleriaViewModel>> GetAllViewModelWithInclude();
    }
}
