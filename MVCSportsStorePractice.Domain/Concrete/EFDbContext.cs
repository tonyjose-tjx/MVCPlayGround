using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MVCSportsStorePractice.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Entities.Product> Products { get; set; }

    }
}
