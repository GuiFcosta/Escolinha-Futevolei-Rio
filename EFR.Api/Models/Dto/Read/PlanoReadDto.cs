namespace EFR.Api.Models.Dto.Read;

public class PlanoReadDto
{
    public int PlanoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public int Duracao { get; set; }
    public bool Ativo { get; set; }
    public int EscolinhaId { get; set; }
}
