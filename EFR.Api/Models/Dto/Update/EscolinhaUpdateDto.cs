using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Dto.Update;

public class EscolinhaUpdateDto
{
    [Required]
    [MaxLength(150)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string Local { get; set; } = string.Empty;

    [Required]
    [MaxLength(77)]
    public string ChavePix { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string TipoChavePix { get; set; } = string.Empty;

    [MaxLength(15)]
    public string WhatsApp { get; set; } = string.Empty;

    public int ConfiguracaoId { get; set; }
}
