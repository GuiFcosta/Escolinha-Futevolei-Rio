using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class AulaUpdateDto
{
    [Required]
    public DateTime HoraInicio { get; set; }

    public DateTime? HoraFim { get; set; }

    [Required]
    public string Local { get; set; } = string.Empty;

    [Required]
    public int ProfessorId { get; set; }

    [Required]
    public int TurmaId { get; set; }
}
