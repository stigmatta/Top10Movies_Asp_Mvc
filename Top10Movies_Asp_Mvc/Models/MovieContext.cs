using Microsoft.EntityFrameworkCore;

namespace Top10Movies_Asp_Mvc.Models
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.Id);
            modelBuilder.Entity<Movie>()
                .Property(m => m.Year)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .ToTable(t => t.HasCheckConstraint("CK_Movie_Year", "Year>=1900 AND Year<=2025"));
            modelBuilder.Entity<Movie>()
                .Property(m => m.Author)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(m=>m.Description)
                .IsRequired();
            modelBuilder.Entity<Movie>()
                .Property(m=>m.ImageLink)
                .IsRequired();
        }
    }
}
