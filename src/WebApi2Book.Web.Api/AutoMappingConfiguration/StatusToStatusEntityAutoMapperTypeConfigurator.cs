﻿using AutoMapper;
using WebApi2Book.Common.TypeMapping;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class StatusToStatusEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression cfg)
        {
            //Mapper.Initialize(cfg =>
            //{
            cfg.CreateMap<Status, Data.Entities.Status>()
                    .ForMember(opt => opt.Version, x => x.Ignore());
            //});
        }
    }
}