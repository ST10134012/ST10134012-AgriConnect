using FluentValidation;

namespace AgriConnect.Application.Users.RegisterFarmer;

public sealed class RegisterFarmerCommandValidator: AbstractValidator<RegisterFarmerCommand>
{
    
    public RegisterFarmerCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x=> x.Password).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
    }
    
}  