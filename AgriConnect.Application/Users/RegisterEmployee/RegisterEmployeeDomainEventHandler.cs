using AgriConnect.Application.Abstractions.Email;
using AgriConnect.Domain.Users;
using AgriConnect.Domain.Users.Events;
using MediatR;
using Microsoft.Extensions.Logging;


namespace AgriConnect.Application.Users.RegisterEmployee;

public sealed class RegisterEmployeeDomainEventHandler(
    IUserRepository userRepository,
    IEmailService emailService,
    ILogger<RegisterEmployeeDomainEventHandler> logger)
    : INotificationHandler<EmployeeCreatedDomainEvent>
{
    private readonly ILogger<RegisterEmployeeDomainEventHandler> _logger = logger;

    public async Task Handle(EmployeeCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetByIdAsync(notification.Id);
        
       await emailService.SendAsync(user?.Email, "Welcome", "You have been registered as an employee");
    }
}