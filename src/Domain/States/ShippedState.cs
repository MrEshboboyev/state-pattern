using Domain.Interfaces;
using Domain.Models;

namespace Domain.States;

public class ShippedState : IOrderState
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("✅ Payment already processed.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("✅ Order already shipped.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("📦 Order delivered.");
        order.SetState(new DeliveredState());
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("🚫 Cannot cancel order after shipping.");
    }
}
