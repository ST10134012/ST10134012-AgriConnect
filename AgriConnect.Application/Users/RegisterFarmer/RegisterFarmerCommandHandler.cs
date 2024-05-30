using AgriConnect.Application.Abstractions.Authentication;
using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Users;

namespace AgriConnect.Application.Users.RegisterFarmer;

public sealed class RegisterFarmerCommandHandler(
    IAuthenticationService authenticationService,
    IUserRepository userRepository,
    IUnitOfWork unitOfWork)
    : ICommandHandler<RegisterFarmerCommand, RegisterFarmerResponse>
{
    public async Task<Result<RegisterFarmerResponse>> Handle(RegisterFarmerCommand request, CancellationToken cancellationToken)
    {
        var farmer = User.FarmerFactory(
            new FirstName(request.FirstName),
            new LastName(request.LastName),
            new Email(request.Email)
        );  
        
        var identityId = await authenticationService.RegisterAsync(
            farmer,
            request.Password,
            cancellationToken);
        
        if (identityId == null)
        {
            return Result.Failure<RegisterFarmerResponse>(
                new Error("User.Registration","Failed to register employee please try again later"));
        }
         
        farmer.SetIdentityId(identityId);
         
        userRepository.Add(farmer);
         
        await unitOfWork.SaveChangesAsync(cancellationToken);
         
        return new RegisterFarmerResponse(farmer.Id);
         
    }
}