﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iEFCore.S23.E13.Sequence;

#nullable disable

namespace iEFCore.S23.E13.Sequence.Migrations
{
    [DbContext(typeof(SequenceDbContext))]
    partial class SequenceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence("SampleSeq", "dbo")
                .StartsAt(101L)
                .IncrementsBy(20)
                .HasMin(100L)
                .HasMax(2000L)
                .IsCyclic();
#pragma warning restore 612, 618
        }
    }
}
