using Dependency_Injection.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controller;

[ApiController]
[Route("[controller]")]
public class ScopedController : ControllerBase
{
    private readonly IScopedService _scoped1;
    private readonly IScopedService _scoped2;

    public ScopedController(IScopedService scoped1, IScopedService scoped2)
    {
        _scoped1 = scoped1;
        _scoped2 = scoped2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            ScopedService1 = _scoped1.GetOperationId(),
            ScopedService2 = _scoped2.GetOperationId()
        });
    }
}
