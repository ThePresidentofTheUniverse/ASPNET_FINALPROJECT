using System.ComponentModel.DataAnnotations;

namespace FinalProject_ABBOTT.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255, ErrorMessage = "Username cannot be longer than 255 characters.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        [StringLength(255, ErrorMessage = "Password cannot be longer than 255 characters.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [StringLength(255, ErrorMessage = "Password cannot be longer than 255 characters.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
