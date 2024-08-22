using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {

        public ICollection<Pokemon> GetPokemons();

        public Pokemon? GetPokemon(int id);  

        public Pokemon? GetPokemon(String name);
        
        public decimal? GetPokemonRating(int id);

        public bool PokemonExist(int id);
        
    }
}
