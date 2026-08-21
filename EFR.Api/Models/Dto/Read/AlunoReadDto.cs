namespace EFR.Api.Models.Dto.Read;

public class AlunoReadDto
{
    public int AlunoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string WhatsApp { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Responsavel { get; set; } = string.Empty;
    public string DataNascimento { get; set; } = string.Empty;
    public int EscolinhaId { get; set; }
    public int PlanoId { get; set; }
}
