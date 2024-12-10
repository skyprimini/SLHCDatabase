using System.ComponentModel.DataAnnotations;

namespace DogAdoptionWebsite.Models
{
    public class User
    {
        [Key] 
        public int Id { get; set; }
        //
        public string FirstName { get; set; } = "";
   //
        public string LastName { get; set; } = "";

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
        //
        public string Role { get; set; } = "";
 //
 }
}
