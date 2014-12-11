using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace System.Security.Claims
{
    public static class DynamicRoleClaimProvider
    {
        [ObsoleteAttribute("Use ClaimsAuthenticationManager to add claims to a ClaimsIdentity", true)]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public static void AddDynamicRoleClaims(ClaimsIdentity claimsIdentity, IEnumerable<Claim> claims)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
