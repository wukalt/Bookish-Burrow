using BookishBurrow.DataAccess.Data;
using BookishBurrow.DataAccess.Interfaces;

namespace BookishBurrow.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IBookRepository Book { get; private set; }

    public IUserRepository User { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Book = new BookRepository(_context);
        User = new UserRepository(_context);
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}
