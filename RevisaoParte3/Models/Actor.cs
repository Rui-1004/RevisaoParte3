using System.ComponentModel.DataAnnotations;

namespace RevisaoParte3.Models
{
    public class Actor
    {
        public int ActorId { get; set; }

        [StringLength(50, ErrorMessage = "Menos de 50 caracteres")]
        [Required]
        public string Name { get; set; }
    }
}
