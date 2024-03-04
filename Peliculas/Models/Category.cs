using System.ComponentModel.DataAnnotations;

namespace Peliculas.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? NameCategory { get; set; }

        public DateTime CreatedAt{ get; set; }
    }
}
