using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace backend.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            try
            {
                // Add debug to see what claims are available
                var claims = user?.Claims?.ToList();
                
                // Try each claim type that might contain the username
                return user?.FindFirst("given_name")?.Value ??
                       user?.FindFirst(ClaimTypes.Name)?.Value ??
                       user?.FindFirst(ClaimTypes.Email)?.Value ??
                       user?.FindFirst("email")?.Value ??
                       string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}