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

        _context.Add(cliente);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetClientePorId), new {id = cliente.Id }, cliente);
    }

    [HttpGet]
    public IEnumerable<ReadClienteDto> GetClientes([FromQuery]int skip = 0, [FromQuery] int take = 10)
    {
        return _mapper.Map<List<ReadClienteDto>>(_context.Clientes.Skip(skip).Take(take).ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetClientePorId(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault( cliente => cliente.Id == id);

        if (cliente == null) return NotFound();

        var clienteDto = _mapper.Map<ReadClienteDto>(cliente);

        return Ok(clienteDto);
    }
}
