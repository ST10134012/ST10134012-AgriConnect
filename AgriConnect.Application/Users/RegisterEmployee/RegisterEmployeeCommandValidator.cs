using FluentValidation;

namespace AgriConnect.Application.Users.RegisterEmployee;

internal sealed class RegisterEmployeeCommandValidator: AbstractValidator<RegisterEmployeeCommand>
{
    
    public RegisterEmployeeCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty();
        RuleFor(x => x.LastName).NotEmpty();
        RuleFor(x=> x.Password).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
    }
    
}