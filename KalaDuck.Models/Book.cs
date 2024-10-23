using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KalaDuck.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Length(5, 20)]
        public string Title { get; set; } = null!;
        [Length(250, 2000)]
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime ReleaseDateTime { get; set; } = DateTime.Now;
        [Range(1, 100)]
        public decimal Price { get; set; }
        [Range(0.0, 5.0)]
        public float Point { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
