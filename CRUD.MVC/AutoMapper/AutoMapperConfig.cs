using AutoMapper;
using CRUD.Domain.Entities;
using CRUD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(map =>
            {
                map.AddProfile<DomainToViewModelIMappingProfile>();
                map.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}