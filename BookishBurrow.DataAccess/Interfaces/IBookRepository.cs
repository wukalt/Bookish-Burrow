using BookishBurrow.Models;

namespace BookishBurrow.DataAccess.Interfaces;

public interface IBookRepository : IRepository<Book>
{
    Task Update(Book book);
}
