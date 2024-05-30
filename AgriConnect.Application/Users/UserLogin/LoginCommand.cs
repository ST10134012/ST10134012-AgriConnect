using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Users.UserLogin;

public record LoginCommand(string Email, string Password) : ICommand<LoginResponse>;