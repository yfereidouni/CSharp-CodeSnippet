﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iEFCore.S24.E11.FromSQLInterpolated;

#nullable disable

namespace iEFCore.S24.E11.FromSQLInterpolated.Migrations
{
    [DbContext(typeof(FromSQLInterpolatedDbContext))]
    [Migration("20220427132543_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iEFCore.S24.E11.FromSQLInterpolated.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RootTitr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "Image01",
                            NewsBody = "NewsBody01",
                            RootTitr = "RootTitr01",
                            ShortDescription = "ShortDesc01",
                            Title = "Title01"
                        });
                });

            modelBuilder.Entity("iEFCore.S24.E11.FromSQLInterpolated.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Yasser",
                            LastName = "Fereidouni"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Alireza",
                            LastName = "Oroumand"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
