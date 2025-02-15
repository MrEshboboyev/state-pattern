using Domain.Models;

namespace Domain.Interfaces;

public interface IOrderState
{
    void ProcessPayment(Order order);
    void ShipOrder(Order order);
    void DeliverOrder(Order order);
    void CancelOrder(Order order);
}
