using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenHouseApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenHouseApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) 
        { 
            
        }

        public DbSet<GreenHouseConfig> GreenHouseConfigs { get; set; }
    }
}