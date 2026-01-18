using ChainOfResponsibility.DP.Correct.Models;

namespace ChainOfResponsibility.DP.Correct.Handlers;

public class AuthorizationHandler : Handler
{
    public override void Handle(Request request)
    {
        if (!request.IsAuthorized)
            throw new Exception("Authorization failed");

        Console.WriteLine("Authorization passed");
        base.Handle(request);
    }
}
