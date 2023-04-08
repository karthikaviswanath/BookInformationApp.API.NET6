﻿// <auto-generated />
using System;
using BookInformationApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookInformationApp.API.Migrations
{
    [DbContext(typeof(BookInfoAppDBContext))]
    partial class BookInfoAppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookInformationApp.API.Domain_Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "Mark Twain",
                            Description = "This novel centres on a smart mischievous young boy living in a town along the Mississippi River.",
                            Genre = "Fiction",
                            Language = "English",
                            Pages = 244,
                            PublishedDate = new DateTime(1876, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Adventures of Tom Sawyer"
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Agatha Christie",
                            Description = "Considered to be one of Agatha Christie's greatest, and also most controversial mysteries.",
                            Genre = "Mystery Thriller",
                            Language = "English",
                            Pages = 288,
                            PublishedDate = new DateTime(1926, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Murder of Roger Ackroyd"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
