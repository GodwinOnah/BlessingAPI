using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.ApiExtensions
{
    public static class ClaimsPrincipalExtensions
    {

         public static string getEmailfromPrincipleClaims (this ClaimsPrincipal user){
                
            return user.FindFirstValue(ClaimTypes.Email);

         }
        
    }
}