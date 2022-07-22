using Models;
using Repository.Interfaces;
using System.Data.Entity;

namespace Repository
{
    public class UsersRepository : Repository<int, User>, IUsersRepository
    {
        public UsersRepository(DbContext dbContext) : base(dbContext) { }
    }
}
