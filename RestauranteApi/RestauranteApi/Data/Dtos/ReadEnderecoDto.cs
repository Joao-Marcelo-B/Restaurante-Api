using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Data.Dtos;

public class ReadEnderecoDto
{
    public string Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string Cep { get; set; }
}
