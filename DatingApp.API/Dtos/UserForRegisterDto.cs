using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        private const string errorMessagePassword = "You must specify password between 4 and 8 characters.";

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = errorMessagePassword)]
        public string Password { get; set; }
    }
}