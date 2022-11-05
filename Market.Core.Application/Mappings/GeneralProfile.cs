using AutoMapper;
using Market.Core.Application.ViewModels.Articulos;
using Market.Core.Application.ViewModels.Categorias;
using Market.Core.Application.ViewModels.Galeria;
using Market.Core.Application.ViewModels.Usuarios;
using Market.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Articulos, ArticulosViewModel>()
               .ForMember(x => x.Usuario, opt => opt.Ignore())
               .ForMember(x => x.Gallery, opt => opt.Ignore())
              //.ForMember(x => x.Gallery, opt => opt.MapFrom(x => x.Galeria.OrderByDescending(x => x.IdGaleria).Take(4)))
               .ForMember(x => x.Categorias, opt => opt.Ignore())
               .ReverseMap()
               .ForMember(x => x.CreatedTime, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LasModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Articulos, SaveArticulosViewModel>()
               .ForMember(x => x.CategoryID, opt => opt.MapFrom(x=> x.Categorias.Id))
               .ForMember(x => x.UsuarioID, opt => opt.MapFrom(x=> x.Usuario.Id))
               .ForMember(x => x.CategoryList, opt => opt.Ignore())
               .ReverseMap()
               .ForMember(x => x.Usuario, opt => opt.Ignore())
               .ForMember(x => x.Categorias, opt => opt.Ignore())
               .ForMember(x => x.Galeria, opt => opt.Ignore())
               .ForMember(x => x.CreatedTime, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LasModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Categorias, CategoriaViewModel>()
               .ForMember(x => x.CategoryArti, opt => opt.Ignore())
               .ForMember(x => x.CountArti, opt => opt.MapFrom(x => x.CategoriaArti.Count()))
               //Contar usuarios
               .ForMember(x => x.UserQuantity, opt => opt.MapFrom(x => x.CategoriaArti.Select(x=> x.UsuarioID.ToString().Count())))
              //Prueba.ForMember(x => x.UserQuantity, opt => opt.MapFrom(x => x.CategoriaArti.Count(x=> x.Usuario.ArticulosUser.Count().ToString())))
               .ReverseMap()
               .ForMember(x => x.CreatedTime, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LasModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Categorias, SaveCategoriaViewModel>()               
               .ReverseMap()
               .ForMember(x => x.CategoriaArti, opt => opt.Ignore())               
               .ForMember(x => x.CreatedTime, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LasModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

           CreateMap<Usuarios, UsuarioViewModel>()
              .ForMember(x => x.ArticulosUser, opt => opt.Ignore())              
              .ReverseMap()
              .ForMember(x => x.CreatedTime, opt => opt.Ignore())
              .ForMember(x => x.CreatedBy, opt => opt.Ignore())
              .ForMember(x => x.LasModified, opt => opt.Ignore())
              .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Usuarios, SaveUsuarioViewModel>()
               .ReverseMap()
               .ForMember(x => x.ArticulosUser, opt => opt.Ignore())
               .ForMember(x => x.CreatedTime, opt => opt.Ignore())
               .ForMember(x => x.CreatedBy, opt => opt.Ignore())
               .ForMember(x => x.LasModified, opt => opt.Ignore())
               .ForMember(x => x.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Galeria, SaveGaleriaViewModel>()
                .ReverseMap()
                .ForMember(x => x.Articulos, opt => opt.Ignore());

            CreateMap<Galeria, SaveGaleriaViewModel>()
                .ReverseMap();
        }
    }
}
