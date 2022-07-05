using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VikingShop.Models;
using VikingShop.Models.DB;

namespace VikingShop
{
    public class VikingShopDbContext : DbContext
    {
        public VikingShopDbContext(DbContextOptions<VikingShopDbContext> options) : base(options)
        {
        }
        //tables
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
