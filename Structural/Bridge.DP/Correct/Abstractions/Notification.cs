using Bridge.DP.Correct.Implementations;

namespace Bridge.DP.Correct.Abstractions;

public abstract class Notification
{
    protected readonly IMessageSender _sender;

    protected Notification(IMessageSender sender)
    {
        _sender = sender;
    }

    public abstract void Notify(string message);
}
