using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PracticeDbContext : DbContext
    {
        public PracticeDbContext() : base("name=PracticeBaseEntities")
        {
            Database.SetInitializer<PracticeDbContext>(null);
        }
    }
}
