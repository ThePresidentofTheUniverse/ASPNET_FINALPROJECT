using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;  // for ValidateNever
using Microsoft.AspNetCore.Mvc; //for Remote

//The class that defines a contestant
namespace FinalProject_ABBOTT.Models
{
    public class Contestant
    {
        //The PK
        [Key]
        public int ContestantID { get; set; }

        [Required (ErrorMessage = "Please enter the contestant's first name.")]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage="The contestant's first name cannot contain any special characters.")]
        [StringLength(50, ErrorMessage = "The contestant's first name cannot be longer than 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the contestant's last name.")]
        [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "The contestant's last name cannot contain any special characters.")]
        [StringLength(50, ErrorMessage = "The contestant's last name cannot be longer than 50 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the contestant's school")]
        public int SchoolID { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(SchoolID))] //Had to add the foreign keys for filtering
        [InverseProperty("Contestants")] 
        public virtual School School { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the contestant's primary email address.")]
        [Remote("CheckEmail", "Validation")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", //Guess who found a regex for emails?
            ErrorMessage = "Please enter an email address in a valid format.")] 
        [StringLength(200, ErrorMessage = "The contestant's email cannot be longer than 200 characters.")]
        public string Email {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a valid Division for the contestant to compete in.")]
        public int DivisionID { get; set; }
        [ValidateNever]
        [ForeignKey(nameof(DivisionID))] //Had to add the foreign keys for filtering
        [InverseProperty("Contestants")]
        public Division Division { get; set; } = null!;

        //The bottom two will default to a specific property, thus nothing will be technically validated.

        public bool CheckInStatus { get; set; } = false; //Defaults to the false option

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
