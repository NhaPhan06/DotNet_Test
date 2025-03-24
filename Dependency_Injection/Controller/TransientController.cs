using Dependency_Injection.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controller;

[ApiController]
[Route("[controller]")]
public class TransientController : ControllerBase
{
    private readonly ITransientService _transient1;
    private readonly ITransientService _transient2;

    public TransientController(ITransientService transient1, ITransientService transient2)
    {
        _transient1 = transient1;
        _transient2 = transient2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            TransientService1 = _transient1.GetOperationId(),
            TransientService2 = _transient2.GetOperationId()
        });
    }
}
