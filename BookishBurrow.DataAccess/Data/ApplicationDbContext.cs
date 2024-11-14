using BookishBurrow.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookishBurrow.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Author>().HasData(
            new Author() { Id = 1, Name = "Eric", Family = "Matthes", Age = 43, ShortBio = "Eric Matthes teaches math and science at a small alternative school in southeast Alaska. He has lived in New Hampshire, New York City, and Alaska. " },
            new Author() { Id = 2, Name = "Mark. J", Family = "Price", Age = 35, ShortBio = "Mark J. Price is a Microsoft Specialist: Programming in C# and Architecting Microsoft Azure Solutions, with over 20 years' experience." }
        );

        modelBuilder.Entity<Book>().HasData(
            new Book() { Id = 1, Title = "Python Crash Course", Description = "One of the most visited book for python in 2024.A Guid Line of learning python", AuthorId = 1, ImageUrl = "https://m.media-amazon.com/images/I/71uiG3qqKaL._AC_UF1000,1000_QL80_.jpg" },
            new Book() { Id = 2, Title = "C# 12 And .NET 8", Description = "One of the most visited book for C# in 2024.A Guid Line of learning C#", AuthorId = 2, ImageUrl = "https://m.media-amazon.com/images/I/61YKrMbrdGL._AC_UF1000,1000_QL80_.jpg" }
        );
    }
}
