using System.ComponentModel.DataAnnotations;

namespace FinalProject_ABBOTT.Models
{
    //The class that defines a Division
    public class Division
    {
        //The PK
        public int DivisionID { get; set; }

        [Required (ErrorMessage = "The Division requires a name.")]
        [StringLength(200, ErrorMessage = "The Division's name cannot be longer than 200 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The amount of contestants that can participate is required.")]
        [Range(1, 30, ErrorMessage = "Our facility will only be able to accommodate up to 30 contestants and no less than one.")]
        public int TotalContestantSlots { get; set; } //How many contestants are allowed to compete

        //This is not touched by the creator; gets updated automatically.
        public int FilledContestantSlots { get; set; } //How many contestants are currently enrolled.

        [Required(ErrorMessage = "This division needs a length of time.")]
        public TimeSpan EventTime { get; set; } //How long the event is

        [Required (ErrorMessage = "The designated coordinator is required for this division.")]
        [StringLength(200, ErrorMessage = "The coordinator's name must be less than 200 characters.")]
        public string CoordinatorName { get; set; } = string.Empty; //Who is running the event
    }
}
