using AgriConnect.Domain.Users;

namespace AgriConnect.Infrastructure.Authorization;

public class UserRolesResponse
{
    public Guid UserId { get; init; }
 
    public List<Role> Roles { get; init; } = [];
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
}