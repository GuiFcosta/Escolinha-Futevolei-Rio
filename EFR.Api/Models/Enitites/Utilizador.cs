using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites;

public class Utilizador
{
    [Key]
    public int UtilizadorId { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Nome { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(15)]
    public string WhatsApp { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(30)]
    public string Cref { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Endereco { get; set; } = string.Empty;
    
    [Required]
    public bool Ativo { get; set; } = false;
    
    [Required]
    public bool BiometriaAtivada { get; set; } = false;
    
    [Required]
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    
    [Required]
    public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;
    
    [Required]
    public int EscolinhaId { get; set; }
    
    public Escolinha? Escolinha { get; set; }

    public List<Turma?> Turmas { get; set; } = [];
}
