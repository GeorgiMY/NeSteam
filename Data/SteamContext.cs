using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class SteamContext : DbContext
    {
        public SteamContext() : base() { }

        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameCompany> GameCompanies { get; set; }
        public DbSet<CreatorGame> CreatorGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=DESKTOP-UJV4L9P\\MSI;Initial Catalog=SteamCopy;Integrated Security=True;TrustServerCertificate=True"));
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=STUDENT17;Initial Catalog=SteamCopy;Integrated Security=True;TrustServerCertificate=True"));
        }
    }
}
