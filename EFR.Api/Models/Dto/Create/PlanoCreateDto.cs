using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Create;

public class PlanoCreateDto
{
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public decimal Valor { get; set; }

    [Required]
    public int Duracao { get; set; }

    public bool Ativo { get; set; } = true;

    [Required]
    public int EscolinhaId { get; set; }
}
