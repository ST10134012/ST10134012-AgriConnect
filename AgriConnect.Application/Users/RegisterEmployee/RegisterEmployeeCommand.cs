using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Users.RegisterEmployee;

public record RegisterEmployeeCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : ICommand<RegisterEmployeeResponse>;
 