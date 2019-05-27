using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sun.Domain;
using System.Data;

namespace Sun.Infra.Data.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CreationDate)
               .HasColumnName("CreationDate")
               .HasColumnType(SqlDbType.DateTime.ToString())
               .IsRequired();

            builder.Property(c => c.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType(SqlDbType.DateTime.ToString())
                .IsRequired(false);


            builder.Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(150)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .IsRequired(true);

            
        }
    }
}
