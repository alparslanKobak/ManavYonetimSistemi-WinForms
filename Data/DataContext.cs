using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Data
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DbConnection") { }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<SellProduct> SellProducts { get; set; }

        public DbSet<BuyProduct> BuyProducts { get; set; }


       

    }
}
