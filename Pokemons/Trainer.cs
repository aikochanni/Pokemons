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
        private object cursors;

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

        public void Catch()
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

            if (Console.ReadKey(true).Key == ConsoleKey.W)
            {
                x = 0;
                y = 1;
                Console.WriteLine("[0,1]");
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                x = 0;
                y = -1;
                Console.WriteLine("[0,-1]");
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                x = -1;
                y = 0;
                Console.WriteLine("[-1,0]");
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D)
            {
                x = 1;
                y = 0;
                Console.WriteLine("[1,0]");
            }

            double x2 = 0;
            double y2 = 0;
            var sum = (x + y) + (x2 + y2);

            Console.WriteLine("Suma wektorów = "+sum);
        }
    }
}
