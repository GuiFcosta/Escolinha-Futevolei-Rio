using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class UtilizadorUpdateDto
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

    public bool Ativo { get; set; }

    public bool BiometriaAtivada { get; set; }

    [Required]
    public int EscolinhaId { get; set; }
}
