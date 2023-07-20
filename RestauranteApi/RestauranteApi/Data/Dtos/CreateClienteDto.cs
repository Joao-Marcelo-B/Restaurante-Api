using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Data.Dtos;

public class CreateClienteDto
{
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }
    [Required]
    [StringLength(11, ErrorMessage = "Cpf inválido, deve conter 11 caracteres -"), MinLength(11, ErrorMessage = "Cpf inválido, deve conter 11 caracteres +")]
    public string Cpf { get; set; }
    [StringLength(11)]
    public string Telefone { get; set; }
}
