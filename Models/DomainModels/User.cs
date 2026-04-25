using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema; //for not mapped

    //The code for a user
namespace FinalProject_ABBOTT.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; } = null!;
    }
}
