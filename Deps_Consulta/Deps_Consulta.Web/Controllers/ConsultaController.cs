using Deps_Consulta.Core.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Deps_Consulta.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultaController : ControllerBase
{
    [Authorize]
    [HttpPost("consultar")]
    public async Task<IActionResult> Consultar([FromBody] ExternalConsultaRequest payload)
    {
        if (payload == null || string.IsNullOrEmpty(payload.Documento))
            return BadRequest("Dados de consulta inválidos.");


        var response = new
        {
            Message = "Consulta processada com sucesso"
        };

        return Ok(response);
    }
}