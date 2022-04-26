﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iEFCore.TablePerType;

#nullable disable

namespace iEFCore.TablePerType.Migrations
{
    [DbContext(typeof(TptDbContext))]
    partial class TptDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iEFCore.TablePerType.Person", b =>
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

                    b.ToTable("People");
                });

            modelBuilder.Entity("iEFCore.TablePerType.Student", b =>
                {
                    b.HasBaseType("iEFCore.TablePerType.Person");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("iEFCore.TablePerType.Teacher", b =>
                {
                    b.HasBaseType("iEFCore.TablePerType.Person");

                    b.Property<string>("TeacherNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Teachers", (string)null);
                });

            modelBuilder.Entity("iEFCore.TablePerType.Student", b =>
                {
                    b.HasOne("iEFCore.TablePerType.Person", null)
                        .WithOne()
                        .HasForeignKey("iEFCore.TablePerType.Student", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iEFCore.TablePerType.Teacher", b =>
                {
                    b.HasOne("iEFCore.TablePerType.Person", null)
                        .WithOne()
                        .HasForeignKey("iEFCore.TablePerType.Teacher", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}