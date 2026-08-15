using System.ComponentModel.DataAnnotations;

namespace EFR.Api.Models.Enitites
{
    public class Plano
    {
        [Key]
        public int PlanoId { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; } = string.Empty;
        
        [Required]
        public decimal Valor { get; set; }
        
        [Required]
        public int Duracao { get; set; }
        
        [Required]
        public bool Ativo { get; set; } = false;
        
        [Required]
        public int EscolinhaId { get; set; }
        
        public Escolinha? Escolinha { get; set; }
    }
}
