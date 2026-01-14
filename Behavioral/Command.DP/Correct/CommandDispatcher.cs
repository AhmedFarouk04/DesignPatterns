using Command.DP.Correct.Commands;
using Command.DP.Correct.Handlers;
using Command.DP.Handlers;

namespace Command.DP;

public class CommandDispatcher
{
    private readonly Dictionary<Type, object> _handlers = new();

    public void Register<TCommand>(ICommandHandler<TCommand> handler)
        where TCommand : ICommand
    {
        _handlers[typeof(TCommand)] = handler;
    }

    public void Dispatch<TCommand>(TCommand command)
        where TCommand : ICommand
    {
        var handler = (ICommandHandler<TCommand>)_handlers[typeof(TCommand)];
        handler.Handle(command);
    }
}
