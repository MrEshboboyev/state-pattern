using Domain.Interfaces;
using Domain.Models;

namespace Domain.States;

public class DeliveredState : IOrderState
{
    public void ProcessPayment(Order order) => Console.WriteLine("✅ Payment already processed.");
    public void ShipOrder(Order order) => Console.WriteLine("✅ Order already shipped.");
    public void DeliverOrder(Order order) => Console.WriteLine("✅ Order already delivered.");
    public void CancelOrder(Order order) => Console.WriteLine("🚫 Cannot cancel a delivered order.");
}
