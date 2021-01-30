using System.Data.Entity;

namespace WarehouseAccounting.Model
{
    public class DB : DbContext
    {
        public DB() : base("DbConnection") { }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}