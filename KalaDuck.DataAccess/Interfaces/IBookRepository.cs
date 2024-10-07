using KalaDuck.Models;

namespace KalaDuck.DataAccess.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        void Update(Book book);
    }
}
