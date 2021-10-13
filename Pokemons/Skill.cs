using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    public class Skill
    {
        public string Name;
        public int BaseDMG;
        public string Type;

        public Skill(string name, int base_dmg, string type)
        {
            Name = name;
            BaseDMG = base_dmg;
            Type = type;
        }
    }
}
