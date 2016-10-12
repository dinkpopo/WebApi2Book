using System;
using System.Security.Claims;
using System.Web;
using System.Linq;

namespace WebApi2Book.Web.Common.Security
{
    public class UserSession : IWebUserSession
    {
        public string Firstname
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;

                return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.GivenName).Value;
            }
        }

        public string Lastname
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;

                return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Surname).Value;
            }
        }

        public string Username
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;

                return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Name).Value;
            }
        }

        public bool IsInRole(string roleName)
        {
            return HttpContext.Current.User.IsInRole(roleName);
        }

        public Uri RequestUri
        {
            get
            {
                if (HttpContext.Current == null)
                    return null;

                return HttpContext.Current.Request.Url;
            }
        }

        public string HttpRequestMethod
        {
            get
            {
                if (HttpContext.Current == null)
                    return string.Empty;

                return HttpContext.Current.Request.HttpMethod;
            }
        }

        public string ApiVersionInUse
        {
            get
            {
                const int versionIndex = 2;
                if (HttpContext.Current.Request.Url.Segments.Length < versionIndex + 1)
                {
                    return string.Empty;
                }

                var apiVersionInUse = HttpContext.Current.Request.Url.Segments[versionIndex].Replace(
                    "/", string.Empty);
                return apiVersionInUse;
            }
        }
    }
}