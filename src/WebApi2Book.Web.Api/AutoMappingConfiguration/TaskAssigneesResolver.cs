using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi2Book.Common.TypeMapping;
using WebApi2Book.Web.Common;
using User = WebApi2Book.Web.Api.Models.User;

namespace WebApi2Book.Web.Api.AutoMappingConfiguration
{
    public class TaskAssigneesResolver : IValueResolver<Data.Entities.Task, Models.Task, List<User>>
    {
        public IAutoMapper AutoMapper => WebContainerManager.Get<IAutoMapper>();

        public List<User> Resolve(Data.Entities.Task source, Models.Task destination, List<User> destMember, ResolutionContext context)
        {
            return source.Users.Select(x => AutoMapper.Map<User>(x)).ToList();
        }
    }
}