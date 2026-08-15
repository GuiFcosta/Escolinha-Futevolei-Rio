using System.ComponentModel.DataAnnotations;
namespace EFR.Api.Models.Enitites
{
    public class Escolinha
    {
        [Key]
        public int EscolinhaId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(50)]
        public string Local { get; set; } = string.Empty;
        
        [Required]
        [MaxLength(77)]
        public string ChavePix { get; set; } = string.Empty;
        
        [MaxLength(12)]
        public string Telefone { get; set; } = string.Empty;
        
        public List<Professor?> Professores { get; set; } = [];
        
        public List<Aluno?> Alunos { get; set; } = [];
        
        public List<Turma?> Turmas { get; set; } = [];
    }    
}
