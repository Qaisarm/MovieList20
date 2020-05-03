﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieList20.Data;

namespace MovieList20.Migrations
{
    [DbContext(typeof(MovieList20Context))]
    partial class MovieList20ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieList20.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = 3,
                            Rating = 5f,
                            ReleaseDate = new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Titanic"
                        },
                        new
                        {
                            Id = 2,
                            Genre = 0,
                            Rating = 2.3f,
                            ReleaseDate = new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Screem"
                        },
                        new
                        {
                            Id = 3,
                            Genre = 0,
                            Rating = 4.4f,
                            ReleaseDate = new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 4,
                            Genre = 4,
                            Rating = 4.1f,
                            ReleaseDate = new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "300"
                        },
                        new
                        {
                            Id = 5,
                            Genre = 3,
                            Rating = 4.8f,
                            ReleaseDate = new DateTime(2014, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = 6,
                            Genre = 4,
                            Rating = 4.4f,
                            ReleaseDate = new DateTime(2008, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Knight"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
