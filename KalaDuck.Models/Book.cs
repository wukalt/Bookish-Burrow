using System.ComponentModel.DataAnnotations.Schema;

namespace KalaDuck.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime ReleaseDateTime { get; set; } = DateTime.Now;

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
