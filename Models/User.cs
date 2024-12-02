using System.ComponentModel.DataAnnotations;

namespace DogAdoptionWebsite.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Role is required.")]
        public string Role { get; set; } = "";

        [Required(ErrorMessage = "Age group is required.")]
        public string Age { get; set; } = "";

        [Required(ErrorMessage = "Current number of pets is required.")]
        public string CurrentNumberOfPets { get; set; } = "";

        [Required(ErrorMessage = "Employment status is required.")]
        public string EmploymentStatus { get; set; } = "";
    }
}
