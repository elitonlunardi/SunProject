﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sun.Infra;

namespace Sun.Infra.Data.Migrations
{
    [DbContext(typeof(SunContext))]
    [Migration("20190526123048_NullCorrectionCity")]
    partial class NullCorrectionCity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sun.Domain.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Sun.Domain.Weather", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CityId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Maximum");

                    b.Property<double>("Minimum");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("Sun.Domain.Weather", b =>
                {
                    b.HasOne("Sun.Domain.City", "City")
                        .WithMany("Weathers")
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}
