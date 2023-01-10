using System.ComponentModel.DataAnnotations;

namespace RevisaoParte3.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [StringLength(50, ErrorMessage = "Menos de 50 caracteres")]
        [Required]
        public string Name { get; set; }
    }
}
