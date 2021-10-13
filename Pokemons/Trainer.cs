using System;
using System.Collections.Generic;

namespace Pokemons
{
    public class Trainer
    {
        private string Name;
        private List<Pokemon> Pokedex;
        private List<Pokemon> Team;
        private Cords Location;

        public Trainer(string name)
        {
            Name = name;
            Pokedex = new List<Pokemon>();
            Team = new List<Pokemon>();
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public List<Pokemon> GetPokemons()
        {
            return Pokedex;
        }

        public void Catch(Pokemon)
        {
            if (Team.Capacity() > 6)
            {
                Pokedex.Add(new Pokemon());
            } else if (Team.Capacity() < 6)
            {
                Team.Add(new Pokemon());
                Pokedex.Add(new Pokemon());
            }
        }

        public void Release(int index)
        {
            Team.Remove(Pokemon[index]);
        }

        public List<Pokemon> GetTeam()
        {
            return Team;
        }

        public void DisplayTeam()
        {
            Team.ForEach(num => Console.WriteLine(num + ", "));
            Console.WriteLine();
        }

        public void MoveBy(double x, double y)
        { 
            double x2 = 8;
            double y2 = 10;
            var sum = (x + y) + (x2 + y2);
        }
    }
}
