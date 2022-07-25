using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Poiskfile
{
 

        public class DataContext : DbContext
        {
            public DataContext() : base() { }
            public DbSet<MeteoData> MeteoDatas { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseMySql("server=localhost;user=root;password=root;database=meteonasa;", new MySqlServerVersion(new Version(10, 3, 0)));
        }
        }
   

}
