using MediatR;
using Mediator.DP.Corret.Notifications;

namespace Mediator.DP.Corret.NotificationHandlers;

public class SendEmailHandler
    : INotificationHandler<OrderCreatedNotification>
{
    public Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Email sent for order {notification.OrderId}");
        return Task.CompletedTask;
    }
}
