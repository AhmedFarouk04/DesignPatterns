using ChainOfResponsibility.DP.Correct.Models;

namespace ChainOfResponsibility.DP.Wrong;

public class RequestProcessor
{
    public void Handle(Request request)
    {
        if (!request.IsAuthenticated)
            throw new Exception("Authentication failed");

        if (!request.IsAuthorized)
            throw new Exception("Authorization failed");

        Console.WriteLine("Request processed");
    }
}
