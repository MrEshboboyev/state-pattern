using Microsoft.AspNetCore.Mvc;
using Domain.Models;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly Order _order = new(101, "Laptop", 1200, "customer@example.com");

    [HttpPost("pay")]
    public IActionResult Pay() { _order.ProcessPayment(); return Ok(); }

    [HttpPost("ship")]
    public IActionResult Ship() { _order.ShipOrder(); return Ok(); }

    [HttpPost("deliver")]
    public IActionResult Deliver() { _order.DeliverOrder(); return Ok(); }

    [HttpPost("cancel")]
    public IActionResult Cancel() { _order.CancelOrder(); return Ok(); }
}
