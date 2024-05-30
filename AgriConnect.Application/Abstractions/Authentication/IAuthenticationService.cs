using AgriConnect.Domain.Users;

namespace AgriConnect.Application.Abstractions.Authentication;


public interface IAuthenticationService
{
    Task<string?> RegisterAsync(
        User user,
        string password,
        CancellationToken cancellationToken = default);
    
    Task<string?> LoginAsync(string email, string password, CancellationToken cancellationToken = default);
    Task SignOutAsync();
} 