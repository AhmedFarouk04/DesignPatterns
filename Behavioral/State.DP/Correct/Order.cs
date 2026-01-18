using State.DP.Correct.States;

namespace State.DP.Correct;

public class Order
{
    private IOrderState _state;

    public Order()
    {
        _state = new NewOrderState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Pay()
    {
        _state.Pay(this);
    }

    public void Ship()
    {
        _state.Ship(this);
    }
}
