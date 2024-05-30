using AgriConnect.Application.Caching;
using AgriConnect.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace AgriConnect.Infrastructure.Authorization;

internal sealed class AuthorizationService(ApplicationDbContext dbContext, ICacheService _cacheService)
{
    public async Task<UserRolesResponse> GetRolesForUserAsync(string identityId)
    {
        // var cacheKey = $"auth-roles-{identityId}";
        // var cachedRoles = await _cacheService.GetAsync<UserRolesResponse>(cacheKey);
        //
        // if (cachedRoles is not null)
        // {
        //     return cachedRoles;
        // } 

        var roles = await dbContext.Set<User>()
            .Where(u => u.IdentityId == identityId)
            .Select(u => new UserRolesResponse
            {
                UserId = u.Id,
                FirstName = u.FirstName.Value.ToString(),
                LastName = u.LastName.Value.ToString(),
                Roles = new List<Role>()
                {
                    new Role(u.RoleId, u.Role.Name)
                }
            })
            .FirstAsync();
 
        //await _cacheService.SetAsync(cacheKey, roles);

        return roles;
    }
}