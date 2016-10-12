using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi2Book.Common.TypeMapping;

namespace WebApi2Book.Web.Api
{
    public class AutoMapperConfigurator
    {
        public void Configure(IEnumerable<IAutoMapperTypeConfigurator> autoMapperTypeConfigurations)
        {
            Mapper.Initialize(cfg =>
            {
                autoMapperTypeConfigurations.ToList().ForEach(x => x.Configure(cfg));
            });

            Mapper.AssertConfigurationIsValid();
        }
    }
}