using AutoMapper;
using WebApi2Book.Common.TypeMapping;
using WebApi2Book.Web.Api.Models;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class UserToUserEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator
    {
        public void Configure(IMapperConfigurationExpression cfg)
        {
            //Mapper.Initialize(cfg =>
            //{
            cfg.CreateMap<User, Data.Entities.User>()
                    .ForMember(opt => opt.Version, x => x.Ignore());
            //});
        }
    }
}