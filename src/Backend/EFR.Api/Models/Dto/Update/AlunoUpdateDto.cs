using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class AlunoUpdateDto
{
    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [MaxLength(15)]
    public string WhatsApp { get; set; } = string.Empty;

    [Required]
    public string Status { get; set; } = string.Empty;

    [Required]
    public string Responsavel { get; set; } = string.Empty;

    [Required]
    public string DataNascimento { get; set; } = string.Empty;

    [Required]
    public int EscolinhaId { get; set; }

    [Required]
    public int PlanoId { get; set; }
}
