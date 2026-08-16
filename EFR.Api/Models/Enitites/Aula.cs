using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites
{
    public class Aula
    {
        [Key]
        public int AulaId { get; set; }

        [Required]
        public DateTime HoraInicio { get; set; }
        
        [Required]
        public DateTime? HoraFim { get; set; } 
        
        [Required]
        public string Local { get; set; } = string.Empty;
        
        [Required]
        public int ProfessorId { get; set; }
        
        public Utilizador? Professor { get; set; }

        [Required]
        public int TurmaId { get; set; }

        public Turma? Turma { get; set; }
    }
}

