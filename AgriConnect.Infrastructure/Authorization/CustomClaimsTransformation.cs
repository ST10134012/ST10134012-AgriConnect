using System.Security.Claims;
using AgriConnect.Infrastructure.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.JsonWebTokens;

namespace AgriConnect.Infrastructure.Authorization;

internal sealed class CustomClaimsTransformation(IServiceProvider serviceProvider) : IClaimsTransformation
{
     
    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        using var scope = serviceProvider.CreateScope();

        var authorizationService = scope.ServiceProvider.GetRequiredService<AuthorizationService>();

        var identityId = principal.GetIdentityId(); 
        
        var userRoles = await authorizationService.GetRolesForUserAsync(identityId); 

        var claimsIdentity = new ClaimsIdentity(); 
        
        claimsIdentity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub, userRoles.UserId.ToString()));
        
        claimsIdentity.AddClaim(new Claim(JwtRegisteredClaimNames.GivenName, userRoles.FirstName));
        
        claimsIdentity.AddClaim(new Claim(JwtRegisteredClaimNames.FamilyName, userRoles.LastName));
 
        foreach (var  role in userRoles.Roles)
        { 
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, role.Name));
        }
        
        principal.AddIdentity(claimsIdentity);
        
        return principal;
    }
}   