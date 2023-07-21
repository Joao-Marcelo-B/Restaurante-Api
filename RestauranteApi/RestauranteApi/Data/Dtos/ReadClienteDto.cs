using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Data.Dtos;

public class ReadClienteDto
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public ReadEnderecoDto Endereco { get; set; }
}
