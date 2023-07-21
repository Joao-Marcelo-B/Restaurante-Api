using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestauranteApi.Data;
using RestauranteApi.Data.Dtos;
using RestauranteApi.Models;

namespace RestauranteApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private RestauranteContext _context;
    private IMapper _mapper;
    public EnderecoController(RestauranteContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostEndereco([FromBody]CreateEnderecoDto dto)
    {
        Endereco endereco = _mapper.Map<Endereco>(dto);

        _context.Add(endereco);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetEnderecoPorId), new {id = endereco.Id}, endereco);
    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto> GetEnderecos() 
    {
        return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetEnderecoPorId(int id)
    {
        var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);

        if (endereco == null) return NotFound();

        var enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

        return Ok(enderecoDto);
    }
}
