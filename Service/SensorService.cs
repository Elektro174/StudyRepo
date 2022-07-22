using Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service
{
    public class SensorService : EntityService<int, Sensors>, ISensorService
    {
        public SensorService(IUnitOfWork unitOfWork, IRepository<int ,Sensors> repository) : base(unitOfWork, repository) { }
    }
}
