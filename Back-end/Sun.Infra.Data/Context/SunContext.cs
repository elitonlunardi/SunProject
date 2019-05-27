using Microsoft.EntityFrameworkCore;
using Sun.Domain;
using Sun.Infra.Data.Mappings;

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
            modelBuilder.ApplyConfiguration(new CityMap());
            modelBuilder.ApplyConfiguration(new WeatherMap());

            //modelBuilder.RemovePluralizing


        }
    }
}
