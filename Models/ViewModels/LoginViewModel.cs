using System.ComponentModel.DataAnnotations;

namespace FinalProject_ABBOTT.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username cannot be longer than 255 characters.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255, ErrorMessage = "Password cannot be longer than 255 characters.")]
        public string Password { get; set; } = string.Empty;

        public string ReturnUrl { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}
