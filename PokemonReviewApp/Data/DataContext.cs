using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {
        
        }

        public DbSet<Pokemon> Pokemon { get; set; }

        public DbSet<Owner> Owners { get; set; }    

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Country> Countries { get; set; }

        public DbSet<Reviewer> Reivewrs { get; set; }    

        public DbSet<Review> Reviews { get; set; }

        public DbSet<PokemonCategory> PokemonCategories { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
