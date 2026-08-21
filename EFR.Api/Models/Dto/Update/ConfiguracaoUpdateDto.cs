using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class ConfiguracaoUpdateDto
{
    public bool NotificarCobrancas { get; set; } = true;

    public bool LembreteChamadas { get; set; } = true;

    public int TempoChuvaHoras { get; set; } = 2;

    [Required]
    public int EscolinhaId { get; set; }
}
