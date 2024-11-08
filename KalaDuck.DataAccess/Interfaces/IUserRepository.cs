using KalaDuck.Models;

namespace KalaDuck.DataAccess.Interfaces;

public interface IUserRepository : IRepository<ApplicationUser>
{
    Task Update(ApplicationUser user);
}
