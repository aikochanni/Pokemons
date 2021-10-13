using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    public class Pokemon
    {
        private string Name;
        private List<Skill> Skills;
        private string Type;
        private int HP;
        private int Level;

        public Pokemon(string name, List<Skill> skills, string type, int hp, int level)
        {
            Name = name;
            List<Skill> Skills = new List<Skill>();
            Type = type;
            HP = hp;
            Level = level;
            level = 1;

        }

        public string DisplayName()
        {
            Console.WriteLine(Name);
            return null;
        }

        public List<Skill> ListSkills()
        {
            var var_List = new List<Skill>();
            return var_List;
        }

        public List<Skill> getSkill(int index)
        {
            return Skills;
        }

        public string ShowStats()
        {
            Console.WriteLine(HP + Level);
            return null;
        }

        public int GetHP()
        {
            return HP;
        }

        public int GetLevel()
        {
            return Level;
        }

    }
}
