using KalaDuck.Models;

namespace KalaDuck.DataAccess.Interfaces;

public interface IBookRepository : IRepository<Book>
{
    Task Update(Book book);
}
