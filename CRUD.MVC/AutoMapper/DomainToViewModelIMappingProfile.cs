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
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }

        //protected override void Configure()
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<ClienteViewModel, Cliente>();
        //        cfg.CreateMap<ProdutoViewModel, Cliente>();
        //    });
        //}
    }
}