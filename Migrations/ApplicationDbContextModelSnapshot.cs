﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task2.Data;

#nullable disable

namespace task2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("task2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Name = "Waleed",
                            Title = "Nablus"
                        },
                        new
                        {
                            Id = 2,
                            Age = 31,
                            Name = "Ahmad",
                            Title = "Tulkarm"
                        },
                        new
                        {
                            Id = 3,
                            Age = 25,
                            Name = "Tariq",
                            Title = "Ramallah"
                        },
                        new
                        {
                            Id = 4,
                            Age = 44,
                            Name = "Rami",
                            Title = "Nablus"
                        },
                        new
                        {
                            Id = 5,
                            Age = 63,
                            Name = "Shadi",
                            Title = "Selfit"
                        },
                        new
                        {
                            Id = 6,
                            Age = 41,
                            Name = "Sami",
                            Title = "Jinen"
                        },
                        new
                        {
                            Id = 7,
                            Age = 20,
                            Name = "Khaled",
                            Title = "Nablus"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
