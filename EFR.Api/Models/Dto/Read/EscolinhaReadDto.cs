namespace EFR.Api.Models.Dto.Read;

public class EscolinhaReadDto
{
    public int EscolinhaId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Local { get; set; } = string.Empty;
    public string ChavePix { get; set; } = string.Empty;
    public string TipoChavePix { get; set; } = string.Empty;
    public string WhatsApp { get; set; } = string.Empty;
    public string CriadoEm { get; set; } = string.Empty;
    public string AtualizadoEm { get; set; } = string.Empty;
    public int ConfiguracaoId { get; set; }
    public Dictionary<int, string> Professores { get; set; } = [];
    public Dictionary<int, string> Alunos { get; set; } = [];
    public List<int> TurmasId { get; set; } = [];
}