using API_FullTrack.Model;
using Microsoft.EntityFrameworkCore;

namespace API_FullTrack.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=API_FullTrackDB;ConnectRetryCount=0");
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}