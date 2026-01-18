using ChainOfResponsibility.DP.Correct.Models;

namespace ChainOfResponsibility.DP.Correct.Handlers;

public class LoggingHandler : Handler
{
    public override void Handle(Request request)
    {
        Console.WriteLine("Logging request");
        base.Handle(request);
    }
}
