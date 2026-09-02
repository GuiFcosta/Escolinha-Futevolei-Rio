using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Create;

public class AlunoCreateDto
{
    [Required]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [MaxLength(15)]
    public string WhatsApp { get; set; } = string.Empty;

    [Required]
    public string Status { get; set; } = "Ativo";

    [Required]
    public string Responsavel { get; set; } = string.Empty;

    [Required]
    public string DataNascimento { get; set; } = string.Empty;

    [Required]
    public int EscolinhaId { get; set; }

    [Required]
    public int PlanoId { get; set; }
}
