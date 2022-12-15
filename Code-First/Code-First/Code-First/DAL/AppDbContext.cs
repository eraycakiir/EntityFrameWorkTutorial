using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet <Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString ("SqlCon"));  
        }

        public override int SaveChanges()
        {
            ChangeTracker.Entries().ToList().ForEach(e =>
            {
                if(e.Entity is Product p) 
                
                {
                    if(e.State == EntityState.Added) 
                    {
                        p.CreateDate = DateTime.Now;    
                    }
                }
            });
            return base.SaveChanges();
        }

    }
}
