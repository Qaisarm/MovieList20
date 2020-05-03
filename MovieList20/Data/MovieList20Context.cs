﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieList20.Models;

namespace MovieList20.Data
{
    public class MovieList20Context : DbContext
    {
        public MovieList20Context (DbContextOptions<MovieList20Context> options)
            : base(options)
        {
        }

        public DbSet<MovieList20.Models.Movie> Movie { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie { Id = 1, Title = "Titanic", Genre = Genre.Drama, ReleaseDate = DateTime.Parse("1997-02-25"), Rating = 5.0F },
                    new Movie { Id = 2, Title = "Screem", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("2005-07-25"), Rating = 2.3F },
                    new Movie { Id = 3, Title = "The Shining", Genre = Genre.Horror, ReleaseDate = DateTime.Parse("1997-05-30"), Rating = 4.4F },
                    new Movie { Id = 4, Title = "300", Genre = Genre.Action, ReleaseDate = DateTime.Parse("2000-05-30"), Rating = 4.1F },
                    new Movie { Id = 5, Title = "Interstellar", Genre = Genre.Drama, ReleaseDate = DateTime.Parse("2014-02-1"), Rating = 4.8F },
                    new Movie { Id = 6, Title = "The Dark Knight", Genre = Genre.Action, ReleaseDate = DateTime.Parse("2008-06-12"), Rating = 4.4F }
                );
        }
    }
}
