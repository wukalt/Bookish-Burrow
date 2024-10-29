using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace KalaDuck.Models;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; } = null!;
    public string Family { get; set; } = null!;

    [ForeignKey(nameof(Book))]
    public ICollection<int>? BookIds { get; set; }
    public virtual ICollection<Book>? ShoppingList { get; set; }
}
