namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Gym { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
