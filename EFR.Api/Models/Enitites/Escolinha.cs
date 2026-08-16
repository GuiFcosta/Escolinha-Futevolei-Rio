using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites
{
    public class Escolinha
    {
        [Key]
        public int EscolinhaId { get; set; }
        
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
        
        [Required]
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        
        [Required]
        public DateTime AtualizadoEm { get; set; } = DateTime.Now;
        
        [Required]
        public int ConfiguracaoId { get; set; }
        
        public Configuracao? Configuracao { get; set; }
        
        public List<Utilizador?> Professores { get; set; } = [];
        
        public List<Aluno?> Alunos { get; set; } = [];
        
        public List<Turma?> Turmas { get; set; } = [];
    }    
}
