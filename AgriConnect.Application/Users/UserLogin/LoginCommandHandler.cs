using AgriConnect.Application.Abstractions.Authentication;
using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;

namespace AgriConnect.Application.Users.UserLogin;

public sealed class LoginCommandHandler(
    IAuthenticationService authenticationService
    ): ICommandHandler<LoginCommand, LoginResponse>
{
    public async Task<Result<LoginResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var result = await authenticationService.LoginAsync(request.Email, request.Password, cancellationToken);
        
        if(result is null)
        {
            return Result.Failure<LoginResponse>(
                new Error("User.Login", "Invalid email or password"));
        }
        
        return new LoginResponse(result);
        
    }
}  