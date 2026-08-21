namespace EFR.Api.Models.Dto.Read;

public class UtilizadorReadDto
{
    public int UtilizadorId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string WhatsApp { get; set; } = string.Empty;
    public string Cref { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public bool Ativo { get; set; }
    public bool BiometriaAtivada { get; set; }
    public string CriadoEm { get; set; } = string.Empty;
    public string AtualizadoEm { get; set; } = string.Empty;
    public int EscolinhaId { get; set; }
    public List<int> TurmasId { get; set; } = [];
}
