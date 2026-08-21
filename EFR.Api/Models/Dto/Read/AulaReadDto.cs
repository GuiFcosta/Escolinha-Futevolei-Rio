namespace EFR.Api.Models.Dto.Read;

public class AulaReadDto
{
    public int AulaId { get; set; }
    public string HoraInicio { get; set; } = string.Empty;
    public string? HoraFim { get; set; }
    public string Local { get; set; } = string.Empty;
    public int ProfessorId { get; set; }
    public int TurmaId { get; set; }
}
