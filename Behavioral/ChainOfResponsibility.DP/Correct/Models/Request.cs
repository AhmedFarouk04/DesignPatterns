namespace ChainOfResponsibility.DP.Correct.Models;

public class Request
{
    public bool IsAuthenticated { get; set; }
    public bool IsAuthorized { get; set; }
}
