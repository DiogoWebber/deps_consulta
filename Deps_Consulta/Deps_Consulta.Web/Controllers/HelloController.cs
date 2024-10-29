using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Deps_Consulta.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Hello()
    {
        return Ok("Hello!");
    }
}