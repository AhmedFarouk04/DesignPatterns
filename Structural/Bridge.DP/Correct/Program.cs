using Bridge.DP.Correct.Abstractions;
using Bridge.DP.Correct.Implementations;

Console.WriteLine("=== Bridge Pattern Demo ===");

Notification emailNormal =
    new NormalNotification(new EmailSender());
emailNormal.Notify("System update available");

Notification smsUrgent =
    new UrgentNotification(new SmsSender());
smsUrgent.Notify("Server down!");
