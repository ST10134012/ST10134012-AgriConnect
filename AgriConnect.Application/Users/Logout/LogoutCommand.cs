using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Users.Logout;

public sealed record LogoutCommand() : ICommand<bool>;