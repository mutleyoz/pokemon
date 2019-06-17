using System;

namespace Pokemon.Models
{
    public class Pokemon
    {
        public int id { get; set; }

        public string name { get; set; }

        public Form[] forms { get; set; }

        public Move[] moves { get; set; }

        public Sprites sprites { get; set; }
    }
}
