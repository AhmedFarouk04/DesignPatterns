using ChainOfResponsibility.DP.Correct.Handlers;
using ChainOfResponsibility.DP.Correct.Models;

Console.WriteLine("=== Chain of Responsibility Demo ===");

var auth = new AuthHandler();
var authorization = new AuthorizationHandler();
var logging = new LoggingHandler();

// Build chain
auth.SetNext(authorization);
authorization.SetNext(logging);

// Request
var request = new Request
{
    IsAuthenticated = true,
    IsAuthorized = true
};

// Start chain
auth.Handle(request);
