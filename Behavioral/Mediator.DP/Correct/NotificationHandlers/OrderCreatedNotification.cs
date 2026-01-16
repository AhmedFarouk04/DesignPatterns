using MediatR;

namespace Mediator.DP.Corret.Notifications;

public record OrderCreatedNotification(int OrderId) : INotification;
