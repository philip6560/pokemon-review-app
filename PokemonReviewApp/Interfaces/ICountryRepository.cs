using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        public ICollection<Country> GetCountries();

        public Country? GetCountry(int id);

        public Country? GetCountryByOwner(int ownerId);

        public ICollection<Owner> GetOwnersFromACountry(int countryId);

        public bool CountryExists(int id);
    }
}
