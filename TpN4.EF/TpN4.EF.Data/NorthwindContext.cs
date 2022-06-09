using System.Data.Entity;
using TpN4.EF.Entities;

namespace TpN4.EF.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerID)
                .IsFixedLength();
        }
    }
}
