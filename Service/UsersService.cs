using Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service
{
    public class UsersService : EntityService<int, User>, IUsersService
    {
        public UsersService(IUnitOfWork unitOfWork, IRepository<int, User> repository) : base(unitOfWork, repository) { }
    }
}
