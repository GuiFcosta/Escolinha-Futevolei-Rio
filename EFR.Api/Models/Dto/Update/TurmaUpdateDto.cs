using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class TurmaUpdateDto
{
    [Required]
    public int Capacidade { get; set; }

    [Required]
    public List<string> DiasSemana { get; set; } = [];

    [Required]
    [MaxLength(50)]
    public string Nivel { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = string.Empty;

    [Required]
    public int EscolinhaId { get; set; }
}
