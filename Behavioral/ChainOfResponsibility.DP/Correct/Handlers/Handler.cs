using ChainOfResponsibility.DP.Correct.Models;

namespace ChainOfResponsibility.DP.Correct.Handlers;

public abstract class Handler
{
    protected Handler? Next;

    public void SetNext(Handler next)
    {
        Next = next;
    }

    public virtual void Handle(Request request)
    {
        Next?.Handle(request);
    }
}
