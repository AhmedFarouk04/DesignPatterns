using Bridge.DP.Correct.Implementations;

namespace Bridge.DP.Correct.Abstractions;

public class NormalNotification : Notification
{
    public NormalNotification(IMessageSender sender) : base(sender) { }

    public override void Notify(string message)
    {
        _sender.Send($"[Normal] {message}");
    }
}