namespace EFR.Api.Models.Dto.Read;

public class TurmaReadDto
{
    public int TurmaId { get; set; }
    public int Capacidade { get; set; }
    public List<string> DiasSemana { get; set; } = [];
    public string Nivel { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string CriadoEm { get; set; } = string.Empty;
    public string AtualizadoEm { get; set; } = string.Empty;
    public int EscolinhaId { get; set; }
    public List<int> ProfessoresId { get; set; } = [];
    public List<int> AlunosId { get; set; } = [];
    public List<int> AulasId { get; set; } = [];
}
