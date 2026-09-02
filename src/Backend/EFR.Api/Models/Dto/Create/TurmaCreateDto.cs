using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Create;

public class TurmaCreateDto
{
    [Required]
    public int Capacidade { get; set; } = 10;

    [Required]
    public List<string> DiasSemana { get; set; } = [];

    [Required]
    [MaxLength(50)]
    public string Nivel { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = "Ativa";

    [Required]
    public int EscolinhaId { get; set; }
}
