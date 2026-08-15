using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites
{
    public class Turma
    {
        [Key]
        public int TurmaId { get; set; }

        [Required] 
        public List<Professor> Professores { get; set; } = [];
        
        [Required]
        public List<Aluno> Alunos { get; set; } = [];
    }
}

