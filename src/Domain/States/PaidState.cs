using Domain.Interfaces;
using Domain.Models;

namespace Domain.States;

public class PaidState : IOrderState
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("✅ Payment already processed.");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("📦 Order shipped.");
        order.SetState(new ShippedState());
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("🚫 Cannot deliver order before shipping.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("❌ Order canceled and refunded.");
        order.SetState(new CanceledState());
    }
}
