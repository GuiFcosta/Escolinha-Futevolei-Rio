using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        
        [Required]
        public string Nome { get; set; } = string.Empty;
        
        [Required]
        public string Telefone { get; set; } = string.Empty;
        
        [Required]
        public string Status { get; set; } = string.Empty;
        
        [Required]
        public string Responsavel { get; set; } = string.Empty;
        
        [Required]
        public string DataNascimento { get; set; } = string.Format("dd/MM/yyyy");  
        
        [Required]
        public int EscolinhaId { get; set; }
        
        public Escolinha? Escolinha { get; set; }
        
        [Required]
        public int PlanoId { get; set; }
        
        public Plano? Plano { get; set; }
    }
}

