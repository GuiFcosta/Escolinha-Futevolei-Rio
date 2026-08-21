namespace EFR.Api.Models.Dto.Read;

public class ConfiguracaoReadDto
{
    public int ConfiguracaoId { get; set; }
    public bool NotificarCobrancas { get; set; }
    public bool LembreteChamadas { get; set; }
    public int TempoChuvaHoras { get; set; }
    public int EscolinhaId { get; set; }
    public string AtualizadoEm { get; set; } = string.Empty;
}
