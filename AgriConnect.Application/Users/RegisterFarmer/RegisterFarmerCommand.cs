using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Users.RegisterFarmer;

public record class RegisterFarmerCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
    ) : ICommand<RegisterFarmerResponse>;
 