using Models;
using Repository.Interfaces;
using System.Data.Entity;

namespace Repository
{
    public class SensorRepository : Repository<int, Sensors>, ISensorRepository
    {
        public SensorRepository(DbContext dbContext) : base(dbContext) { }
    }
}
