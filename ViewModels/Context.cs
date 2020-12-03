using Models;
using System.Data.Entity;

namespace ViewModels
{
    class Context : DbContext
    {
        public Context() : base("ConnectionString")
        {
        }

        public DbSet<MCustomer> Customers { get; set; }
        
    }
}