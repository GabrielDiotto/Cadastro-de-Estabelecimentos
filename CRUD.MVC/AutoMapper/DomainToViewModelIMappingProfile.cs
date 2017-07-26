using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.MVC.ViewModels;

namespace CRUD.MVC.AutoMapper
{
    public class DomainToViewModelIMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<EstabelecimentoViewModel, Estabelecimento>();
        }
    }
}