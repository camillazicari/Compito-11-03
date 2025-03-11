using System.ComponentModel.DataAnnotations;

namespace Compito_11_03.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public required string Titolo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public required string Autore { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public required string Genere { get; set; }

        [Required]
        public required bool Disponibilità;

    }
}
