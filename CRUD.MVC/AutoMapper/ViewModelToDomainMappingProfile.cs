using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.MVC.ViewModels;

namespace CRUD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Estabelecimento, EstabelecimentoViewModel>();
        }
    }
}