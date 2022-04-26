﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iEFCore.Configurations.DAL;

#nullable disable

namespace iEFCore.Configurations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220419193401_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iEFCore.Configurations.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("tbl_Contact", "dbo");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.IndexUsingAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "IX_Name_USING_ATTRIBUTE")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("IndexUsingAttributes");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.IndexUsingFluentAPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Filtered")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("IX_Name_USING_FLUENT")
                        .HasFilter("[Filtered] IS NOT NULL");

                    b.ToTable("IndexUsingFluentAPIs");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_People", "dbo");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.PrimaryKeyAttribute", b =>
                {
                    b.Property<int>("MyPrimaryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MyPrimaryKey"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MyPrimaryKey");

                    b.ToTable("PrimaryKeyAttributes");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.PrimaryKeyFluent", b =>
                {
                    b.Property<int>("Pk01")
                        .HasColumnType("int");

                    b.Property<int>("Pk02")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pk01", "Pk02");

                    b.ToTable("PrimaryKeyFluents");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.ReadOnlyAttribute", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ReadOnlyAttributes");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.ReadOnlyFluent", b =>
                {
                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("ReadOnlyFluent");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.Contact", b =>
                {
                    b.HasOne("iEFCore.Configurations.Entities.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("iEFCore.Configurations.Entities.Person", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}