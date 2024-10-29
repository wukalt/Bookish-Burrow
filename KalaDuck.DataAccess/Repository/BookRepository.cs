using KalaDuck.DataAccess.Data;
using KalaDuck.DataAccess.Interfaces;
using KalaDuck.Models;

namespace KalaDuck.DataAccess.Repository;

public class BookRepository : Repository<Book>, IBookRepository
{
    private readonly ApplicationDbContext _context;

    public BookRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public void Update(Book book)
    {
        _context.Books.Update(book);
    }
}
