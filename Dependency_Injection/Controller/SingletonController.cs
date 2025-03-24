using Dependency_Injection.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controller;

[ApiController]
[Route("[controller]")]
public class SingletonController : ControllerBase
{
    private readonly ISingletonService _singleton1;
    private readonly ISingletonService _singleton2;

    public SingletonController(ISingletonService singleton1, ISingletonService singleton2)
    {
        _singleton1 = singleton1;
        _singleton2 = singleton2;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            SingletonService1 = _singleton1.GetOperationId(),
            SingletonService2 = _singleton2.GetOperationId()
        });
    }
}
