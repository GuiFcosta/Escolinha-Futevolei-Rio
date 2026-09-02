using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class PlanoUpdateDto
{
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public decimal Valor { get; set; }

    [Required]
    public int Duracao { get; set; }

    public bool Ativo { get; set; }

    [Required]
    public int EscolinhaId { get; set; }
}
