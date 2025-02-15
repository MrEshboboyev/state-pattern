using System;
using Domain.Interfaces;
using Domain.Models;

namespace Domain.States;

public class PendingState : IOrderState
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("💰 Payment received. Order is now Paid.");
        order.SetState(new PaidState());
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("🚫 Cannot ship order. Payment is pending.");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("🚫 Cannot deliver order. Payment is pending.");
    }

    public void CancelOrder(Order order)
    {
        Console.WriteLine("❌ Order canceled.");
        order.SetState(new CanceledState());
    }
}
