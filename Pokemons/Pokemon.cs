using System;
using System.Collections.Generic;

namespace Pokemons
{
    public class Pokemon
    {
        private string Name;
        private List<Skill> Skills;
        private string Type;
        private int HP;
        private int Level;

        public Pokemon(string name, string type, int hp)
        {
            Name = name;
            Skills = new List<Skill>();
            Type = type;
            HP = hp;
            Level = 1;
        }

        public Pokemon()
        {
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public List<Skill> ListSkills()
        {
            return Skills;
        }

        public Skill getSkill(int index)
        {
            return Skills[index];
        }

        public void ShowStats()
        {
            Console.WriteLine("Poziom zdrowia pokemona wynosi: " + HP + "\n" + "Poziom doświadczenia pokemona wynosi: " + Level);
        }

        public int GetHP()
        {
            return HP;
        }

        public int GetLevel()
        {
            return Level;
        }

        public string GetName()
        {
            return Name;
        }

    }
}
