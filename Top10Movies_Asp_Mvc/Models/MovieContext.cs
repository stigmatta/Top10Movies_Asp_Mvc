using Microsoft.EntityFrameworkCore;

namespace Top10Movies_Asp_Mvc.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }
    }

}
