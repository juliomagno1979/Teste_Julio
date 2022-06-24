using Microsoft.EntityFrameworkCore;
using Paschoalotto.Back.Domain.Entities;


namespace Paschoalotto.Back.Data.Repositories
{

    public class PaschoalottoContext : DbContext
    {
        public PaschoalottoContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the contex
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        public DbSet<Usuario> Usuarios { get; set; }


    }
}
