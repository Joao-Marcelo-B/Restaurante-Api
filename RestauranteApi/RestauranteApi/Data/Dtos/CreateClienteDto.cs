using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Data.Dtos;

public class CreateClienteDto
{
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }
    [Required]
    [MaxLength(11), MinLength(11)]
    public string Cpf { get; set; }
    [MaxLength(10), MinLength(10)]
    public string Telefone { get; set; }
}
