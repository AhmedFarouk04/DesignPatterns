using ChainOfResponsibility.DP.Correct.Models;

namespace ChainOfResponsibility.DP.Correct.Handlers;

public class AuthHandler : Handler
{
    public override void Handle(Request request)
    {
        if (!request.IsAuthenticated)
            throw new Exception("Authentication failed");

        Console.WriteLine("Authentication passed");
        base.Handle(request);
    }
}
