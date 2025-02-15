using Domain.Interfaces;
using Domain.Models;

namespace Domain.States;

public class CanceledState : IOrderState
{
    public void ProcessPayment(Order order) => Console.WriteLine("🚫 Cannot process payment. Order is canceled.");
    public void ShipOrder(Order order) => Console.WriteLine("🚫 Cannot ship a canceled order.");
    public void DeliverOrder(Order order) => Console.WriteLine("🚫 Cannot deliver a canceled order.");
    public void CancelOrder(Order order) => Console.WriteLine("🚫 Order already canceled.");
}
