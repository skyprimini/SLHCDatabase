using System.ComponentModel.DataAnnotations;

namespace DogAdoptionWebsite.Models
{
    public class SecureMessage
    {
        [Key]
        public int SecureMessageId { get; set; }

        //First name of user sending secure message
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        //Last name of user sending message
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = "";

        //User's email, used for admin to be able to contact user after sending message
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = "";

        //Reason for mesage
        public string Subject { get; set; }

        //Message/question from the user
        public string Message { get; set; }
    }
}
