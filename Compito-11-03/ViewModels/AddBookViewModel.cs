using System.ComponentModel.DataAnnotations;

namespace Compito_11_03.ViewModels
{
    public class AddBookViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Titolo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Autore { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public required string Genere { get; set; }

        public required bool Disponibilita { get; set; } = false;
    }
}
