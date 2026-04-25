using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FinalProject_ABBOTT.Models
{
    //This viewmodel has been created to allow me to do more fancy stuff that I am normally
    //not able to do with just a normal class.
    public class ContestantsViewModel
    {
        [ValidateNever]
        public Filters Filters { get; set; } = null!;
        [ValidateNever]
        public List<Division> Divisions { get; set; } = null!;
        [ValidateNever]
        public List<School> Schools { get; set; } = null!;
        [ValidateNever]
        public Dictionary<string, string> CheckedFilters { get; set; } = null!;
        [ValidateNever]
        public List<Contestant> Contestants { get; set; } = null!;
    }
}
