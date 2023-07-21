using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Data.Dtos;

public class CreateEnderecoDto
{
    [Required]
    [MaxLength(50)]
    public string Logradouro { get; set; }
    [Required]
    public int Numero { get; set; }
    [Required]
    [MaxLength(15)]
    public string Cep { get; set; }
}
