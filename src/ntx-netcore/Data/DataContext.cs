using Microsoft.EntityFrameworkCore;
using ntx_netcore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ntx_netcore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
