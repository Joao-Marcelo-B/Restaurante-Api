using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestauranteApi.Data;
using RestauranteApi.Data.Dtos;
using RestauranteApi.Models;

namespace RestauranteApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private RestauranteContext _context;
    private IMapper _mapper;

    public ClienteController(RestauranteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostCliente([FromBody] CreateClienteDto dto)
    {
        Cliente cliente = _mapper.Map<Cliente>(dto);
    }
}
