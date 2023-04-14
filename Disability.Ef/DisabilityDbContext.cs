using Disability.Data.Entities;
using Disability.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disability.Ef
{
    public class DisabilityDbContext : DbContext
    {
        public DisabilityDbContext(DbContextOptions<DisabilityDbContext> option) : base(option)
        {
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration Configuration = builder.Build();

            optionsBuilder.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<DisProductInformation> DisProducts { set; get; }  
        public DbSet<DisNewsInformation> DisNews { set; get; }




        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {

            modelbuilder.Entity<DisProductInformation>(eb => { eb.HasNoKey(); });
            modelbuilder.Entity<DisNewsInformation>(eb => { eb.HasNoKey(); });
        }


    }
}
