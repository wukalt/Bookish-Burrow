using BookishBurrow.Models;

namespace BookishBurrow.DataAccess.Interfaces;

public interface IUserRepository : IRepository<ApplicationUser>
{
    Task Update(ApplicationUser user);
}
