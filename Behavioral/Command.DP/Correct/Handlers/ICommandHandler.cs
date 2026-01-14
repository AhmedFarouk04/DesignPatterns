using Command.DP.Correct.Commands;

namespace Command.DP.Correct.Handlers;

public interface ICommandHandler<TCommand>
    where TCommand : ICommand
{
    void Handle(TCommand command);
}
