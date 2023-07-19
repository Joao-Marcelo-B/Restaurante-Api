using Microsoft.AspNetCore.Mvc;

namespace RestauranteApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    [HttpPost]
    public IActionResult PostCliente([FromBody] CreateClienteDto dto)
    {

    }
}
