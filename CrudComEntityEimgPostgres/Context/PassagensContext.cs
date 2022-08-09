using CrudComEntityEimgPostgres.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudComEntityEimgPostgres.Context
{

    public class PassagensContext:DbContext
    {

        public PassagensContext(DbContextOptions<PassagensContext>options): base(options)
        {

        }

        public DbSet<PassagensUsuarios> Passagens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassagensUsuarios>(p =>
            {
                p.ToTable("Passagens");
                p.HasKey(p => p.Id);

            });

        }
    }
}
