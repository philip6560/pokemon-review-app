using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public Pokemon? GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon? GetPokemon(string name)
        {
            return _context.Pokemon
                .Where(p => p.Name.ToLower() == name.ToLower())
                .FirstOrDefault();
        }

        public decimal? GetPokemonRating(int id)
        {
            var reviews = _context.Reviews.Where(r => r.Pokemon.Id == id);

            if(reviews.Count() <= 0)
                return null;

            return ((decimal)reviews.Sum(r => r.Rating) / reviews.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool PokemonExist(int id)
        {
            return _context.Pokemon.Any(p => p.Id == id);
        }
    }
}
