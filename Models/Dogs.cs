using System.ComponentModel.DataAnnotations;

namespace DogAdoptionWebsite.Models
{
    public class Dog
    {
        public int Id { get; set; }

        // Age of the dog
        public int Age { get; set; }

        // Name of the dog
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }

        // Gender of the dog
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string? Gender { get; set; }

        // Breed of the dog
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Breed { get; set; }

        // Weight of the dog
        public string? Weight { get; set; }

        // Location of the dog
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Location { get; set; }

        // Adoption status
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Status { get; set; }

        // Description of the dog
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Description { get; set; }

        // Image URL of the dog (for displaying on the Adoption page)
        public string? ImageUrl { get; set; }
    }
}
