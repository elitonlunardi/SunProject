using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sun.Domain;
using System.Data;

namespace Sun.Infra.Data.Mappings
{
    public class WeatherMap : IEntityTypeConfiguration<Weather>
    {
        public void Configure(EntityTypeBuilder<Weather> builder)
        {
            builder.ToTable("Weathers");

            builder.HasKey(w => w.Id);


            builder.Property(w => w.CreationDate)
               .HasColumnName("CreationDate")
               .HasColumnType(SqlDbType.DateTime.ToString())
               .IsRequired();

            builder.Property(w => w.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType(SqlDbType.DateTime.ToString())
                .IsRequired(false);

            builder.Property(w => w.Date)
                .HasColumnName("Date")
                .HasColumnType(SqlDbType.DateTime.ToString())
                .IsRequired(true);

            builder.Property(w => w.Minimum)
                .HasColumnName("Minimum")
                .HasColumnType(SqlDbType.Float.ToString())
                .IsRequired(true);

            builder.Property(w => w.Maximum)
                .HasColumnName("Maximum")
                .HasColumnType(SqlDbType.Float.ToString())
                .IsRequired(true);

            builder.HasOne(c => c.City)
                .WithMany(c => c.Weathers)
                .HasForeignKey(c => c.CityId)
                .IsRequired();
        }
    }
}
