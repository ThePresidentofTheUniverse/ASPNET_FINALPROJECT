using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;  // for ValidateNever

//The class that defines a contestant
namespace FinalProject_ABBOTT.Models
{
    public class Contestant
    {
        //The PK
        public int ContestantID { get; set; }

        [Required (ErrorMessage = "Please enter the contestant's first name.")]
        [StringLength(50, ErrorMessage = "The contestant's first name cannot be longer than 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the contestant's last name.")]
        [StringLength(50, ErrorMessage = "The contestant's last name cannot be longer than 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the contestant's school")]
        public int SchoolID { get; set; }
        [ValidateNever]
        public School School { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the contestant's primary email address.")]
        [StringLength(200, ErrorMessage = "The contestant's email cannot be longer than 200 characters.")]
        public string Email {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a valid Division for the contestant to compete in.")]
        public int DivisionID { get; set; }
        [ValidateNever]
        public Division Division { get; set; } = null!;

        //The bottom two will default to a specific property, thus nothing will be technically validated.

        public bool CheckInStatus { get; set; } = false; //Defaults to the false option

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
