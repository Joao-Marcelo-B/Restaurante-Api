﻿using System.ComponentModel.DataAnnotations;
namespace RestauranteApi.Models;

public class Cliente
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; }
    [Required]
    [MaxLength(11), MinLength(11)]
    public string Cpf { get; set; }
    [MaxLength(10), MinLength(10)]
    public string Telefone { get; set; }

}
