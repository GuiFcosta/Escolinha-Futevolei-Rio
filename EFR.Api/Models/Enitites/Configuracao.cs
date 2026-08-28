using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites;

public class Configuracao
{
    [Key]
    public int ConfiguracaoId { get; set; }

    [Required]
    public bool NotificarCobrancas { get; set; } = true;
        
    [Required]
    public bool LembreteChamadas { get; set; } = true;

    [Required]
    public int TempoChuvaHoras { get; set; } = 2;
        
    [Required]
    public int EscolinhaId { get; set; }

    public Escolinha? Escolinha { get; set; }
        
    [Required]
    public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;
}

