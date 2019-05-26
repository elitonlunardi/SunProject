using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sun.Domain;

namespace Sun.Infra
{
    public class SunContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Weather> Weathers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                data source=DESKTOP-5SL3KKS;initial catalog=CityWeatherBase;trusted_connection=true
            ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new MusicMapping());
            //modelBuilder.ApplyConfiguration(new AlbumMapping());
            //modelBuilder.ApplyConfiguration(new BandMapping());
        }
    }
}
