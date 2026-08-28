using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites;

public class Turma
{
    [Key]
    public int TurmaId { get; set; }
    
    [Required]
    public int Capacidade { get; set; } = 10;
    
    [Required]
    public List<string> DiasSemana { get; set; } = [];
    
    [Required]
    [MaxLength(50)]
    public string Nivel { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = string.Empty;
    
    [Required]
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    
    [Required]
    public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;
    
    [Required]
    public int EscolinhaId { get; set; }
    
    public Escolinha? Escolinha { get; set; }

    public List<Utilizador?> Professores { get; set; } = [];
    
    public List<Aluno?> Alunos { get; set; } = [];
    
    public List<Aula?> Aulas { get; set; } = [];
}


