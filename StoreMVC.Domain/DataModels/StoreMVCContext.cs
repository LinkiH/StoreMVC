using System.Data.Common;
using System.Data.Entity;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Domain.DataModels
{
    public class StoreMvcContext : DbContext
    {
        public StoreMvcContext() : base("StoreMvcDb")
        {
            Database.SetInitializer<StoreMvcContext>(new StoreMvcModelInitializer());
        }
        public StoreMvcContext(DbConnection connection) : base(connection, false)
        { }
        public DbSet<Product> Products { get; set; }
    }
}
