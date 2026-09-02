using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Create;

public class UtilizadorCreateDto
{
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(15)]
    public string WhatsApp { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Cref { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Endereco { get; set; } = string.Empty;

    public bool Ativo { get; set; } = true;

    public bool BiometriaAtivada { get; set; } = false;

    [Required]
    public int EscolinhaId { get; set; }
}
