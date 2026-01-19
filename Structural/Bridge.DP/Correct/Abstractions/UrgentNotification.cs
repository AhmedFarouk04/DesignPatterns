using Bridge.DP.Correct.Abstractions;
using Bridge.DP.Correct.Implementations;

public class UrgentNotification : Notification
{
    public UrgentNotification(IMessageSender sender) : base(sender) { }

    public override void Notify(string message)
    {
        _sender.Send($"[URGENT] {message}");
    }
}