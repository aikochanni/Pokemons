using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Pokemon
    {
        private static string name;
        private List<Skill> Skills;
        private static string Type;
        private static int hP;
        private static int level;

        static void Constructor()
        {
            level = 1;
        }

        static void displayName()
        {
            Console.WriteLine(name);
        }

        static void listSkills()
        {
            return Skills();
        }

        static void getSkill(int index)
        {
            return Skill;
        }

        static void showStats(string[] args)
        {

        }

        static void getHP()
        {
            return hP;
        }

        static void getLevel()
        {
            return level;
        }

    }
}
