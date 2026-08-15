using System.ComponentModel.DataAnnotations;
namespace EFR.Api.Models.Enitites
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; } = string.Empty;
        
        [Required]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        public string Telefone { get; set; } = string.Empty;
        
        [Required]
        public string Cref { get; set; } = string.Empty;
        
        [Required]
        public string Endereco { get; set; } = string.Empty;
        
        [Required]
        public bool Ativo { get; set; } = false;

        public List<Turma?> Turmas { get; set; } = [];
    }
}