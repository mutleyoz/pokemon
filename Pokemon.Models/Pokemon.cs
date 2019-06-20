namespace Pokemon.Models
{
    public class PokemonAttributes
    {
        public int id { get; set; }

        public string name { get; set; }

        public Form[] forms { get; set; }

        public PokemonMoves[] moves { get; set; }

        public Sprites sprites { get; set; }
    }
}
