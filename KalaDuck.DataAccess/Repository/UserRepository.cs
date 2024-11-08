using KalaDuck.DataAccess.Data;
using KalaDuck.DataAccess.Interfaces;
using KalaDuck.Models;

namespace KalaDuck.DataAccess.Repository;

public class UserRepository : Repository<ApplicationUser>, IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task Update(ApplicationUser user)
    {
        await Task.Run(() =>
        {
            _context.ApplicationUsers.Update(user);
        });
    }
}
