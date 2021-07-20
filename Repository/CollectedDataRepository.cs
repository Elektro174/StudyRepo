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
    public class CollectedDataRepository : Repository<CollectedData>, ICollectedDataRepository
    {
        public CollectedDataRepository(DbContext dbContext) : base(dbContext) { }
    }
}
