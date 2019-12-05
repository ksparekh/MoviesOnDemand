using Microsoft.EntityFrameworkCore;
using MoviesOnDemand.Models;

namespace MoviesOnDemand.Data.Context
{

    public class MoviesOnDemandDbContext : DbContext
    {
        public MoviesOnDemandDbContext():base() {}

        public MoviesOnDemandDbContext(DbContextOptions<MoviesOnDemandDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<MovieCategory> MovieCategory { get; set; }

        public DbSet<Movie> Movie { get; set; }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MovieCategory>().HasKey(category => category.ID);
            builder.Entity<Movie>().HasKey(movie => movie.ID);
            builder.Entity<User>().HasKey(user => user.ID);
        }
    }

}