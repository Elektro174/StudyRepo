using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsersRepository : Repository<int, User>, IUsersRepository//, IDisposable
    {
        public UsersRepository(DbContext dbContext) : base(dbContext) { }
    }
}
