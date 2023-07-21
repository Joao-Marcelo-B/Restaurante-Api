using System.ComponentModel.DataAnnotations;

namespace RestauranteApi.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Logradouro { get; set; }
    [Required]
    public int Numero { get; set; }
    [Required]
    [MaxLength(15)]
    public string Cep { get; set; }
    public virtual Cliente Cliente { get; set; }

}
