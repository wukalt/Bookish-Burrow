namespace KalaDuck.DataAccess.Interfaces;

public interface IUnitOfWork
{
    IBookRepository Book { get; }
    IUserRepository User { get; }
    Task Commit();
}
