using Domain.Interfaces;
using Domain.States;

namespace Domain.Models;

public class Order(int orderId, string product, decimal amount, string customerEmail)
{
    public int OrderId { get; } = orderId;
    public string Product { get; } = product;
    public decimal Amount { get; } = amount;
    public string CustomerEmail { get; } = customerEmail;
    private IOrderState _state = new PendingState();

    public void SetState(IOrderState state)
    {
        _state = state;
        Console.WriteLine($"🔄 Order {OrderId} is now {_state.GetType().Name.Replace("State", "")}");
    }

    public void ProcessPayment() => _state.ProcessPayment(this);
    public void ShipOrder() => _state.ShipOrder(this);
    public void DeliverOrder() => _state.DeliverOrder(this);
    public void CancelOrder() => _state.CancelOrder(this);
}
