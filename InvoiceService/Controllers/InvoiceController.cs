using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class InvoiceController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new[] { new { Id = 1, Amount = 100.0 } });
}
