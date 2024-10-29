namespace KalaDuck.DataAccess.Interfaces;

public interface IUnitOfWork
{
    IBookRepository Book { get; }
    Task Commit();
}
