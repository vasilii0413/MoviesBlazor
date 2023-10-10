using Microsoft.EntityFrameworkCore;
using Movies.EntityFramework.Models;

namespace Movies.EntityFramework.MoviesDbContext
{
    public class MoviesDBContext : DbContext
    {
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>()
                .HasMany(a => a.Actors)
                .WithMany(b => b.Movies)
                .UsingEntity(j => j.ToTable("ActorMovie"));
        }

        public DbSet<ActorModel> Actors {  get; set; }
        public DbSet<MovieModel>Movies { get; set; }
        public DbSet<ActorMovieModel> ActorsMovies { get; set; }
    }
}
