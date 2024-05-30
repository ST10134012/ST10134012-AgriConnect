using AgriConnect.Application.Abstractions.Authentication;
using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;
 

namespace AgriConnect.Application.Users.Logout;

public sealed class LogoutCommandHandler(IAuthenticationService authenticationService): ICommandHandler<LogoutCommand, bool>
{
    public async Task<Result<bool>> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        await authenticationService.SignOutAsync();
        return Result.Success(true);
    }
}