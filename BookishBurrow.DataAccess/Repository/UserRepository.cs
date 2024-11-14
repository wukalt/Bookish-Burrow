using BookishBurrow.DataAccess.Data;
using BookishBurrow.DataAccess.Interfaces;
using BookishBurrow.Models;

namespace BookishBurrow.DataAccess.Repository;

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
