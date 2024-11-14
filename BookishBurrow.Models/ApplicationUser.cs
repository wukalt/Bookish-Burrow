using Microsoft.AspNetCore.Identity;

namespace BookishBurrow.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; } = null!;
    public string Family { get; set; } = null!;

    // TODO : Add shipping list
}
