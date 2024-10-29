namespace KalaDuck.DataAccess.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll(int taken = 0);
    Task<T> Get(object id);
    Task Add(T entity);
    Task Remove(T entity);
}
