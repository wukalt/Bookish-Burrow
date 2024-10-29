using System.ComponentModel.DataAnnotations;

namespace KalaDuck.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Family { get; set; } = null!;
    public int? Age { get; set; }
    public string? ShortBio { get; set; }
}
