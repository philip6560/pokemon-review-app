using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data.ModelsConfiguration
{
    public class PokemonCategoryConfiguration : IEntityTypeConfiguration<PokemonCategory>
    {
        public void Configure(EntityTypeBuilder<PokemonCategory> builder)
        {
            builder.HasKey(pc => new { pc.PokemonId, pc.CategoryId });

            builder.HasOne(pc => pc.Pokemon)
                .WithMany(p => p.PokemonCategories)
                .HasForeignKey(pc => pc.PokemonId);

            builder.HasOne(pc => pc.Category)
                .WithMany(c => c.PokemonCategories)
                .HasForeignKey(pc => pc.CategoryId);

        }
    }
}
