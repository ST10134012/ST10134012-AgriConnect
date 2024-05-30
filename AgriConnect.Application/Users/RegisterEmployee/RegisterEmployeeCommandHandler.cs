using AgriConnect.Application.Abstractions.Authentication;
using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Users;

namespace AgriConnect.Application.Users.RegisterEmployee;

internal sealed class RegisterEmployeeCommandHandler(
    IUserRepository userRepository,
    IAuthenticationService authenticationService,
    IUnitOfWork unitOfWork)
    : ICommandHandler<RegisterEmployeeCommand, RegisterEmployeeResponse>
{
    public async Task<Result<RegisterEmployeeResponse>> Handle(RegisterEmployeeCommand request, CancellationToken cancellationToken)
    {
        
        var employee = User.EmployeeFactory(
            new FirstName(request.FirstName),
            new LastName(request.LastName),
            new Email(request.Email)
        );
        
        var identityId = await authenticationService.RegisterAsync(
            employee,
            request.Password,
            cancellationToken);
        
        if(identityId is null)
        {
            return Result.Failure<RegisterEmployeeResponse>(
                new Error("User.Registration","Failed to register employee please try again later"));
        }
        
        employee.SetIdentityId(identityId);
          
        userRepository.Add(employee);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return new RegisterEmployeeResponse(employee.Id);
    }
} 