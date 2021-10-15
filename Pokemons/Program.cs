using System;
using System.Collections.Generic;

namespace Pokemons
{
    class Program
    {

    static void Main(string[] args)
        {
            //var charmander = new Pokemon("Charmander", "Fire", 200);
            //var bulbasaur = new Pokemon("Bulbasaur", "Water", 175);
            //charmander.ShowStats();
            //bulbasaur.ShowStats();
            //var lista = new List<Pokemon>();
            //lista.Add(charmander);
            //lista.Add(bulbasaur);
            //Console.WriteLine("Wyszukaj...");
            //string name = Console.ReadLine();
            //var i = lista.Find(n => n.GetName() == name);
            //Console.WriteLine(i.GetName());
            //Console.ReadKey();

            double x = 0;
            double y = 0;
            string name = "";

            Trainer trening = new Trainer(name);
            trening.MoveBy(x, y);

            for (int i=0; i >= 0; i++)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    trening.MoveBy(x, y);
                }
            }


        }
    }
}
