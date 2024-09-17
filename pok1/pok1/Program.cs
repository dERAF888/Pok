using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pok1
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string[] Types { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public string[] SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

        public Pokemon(string имя, string[] Тип, int ХП, int Атака, int Защита, string[] СпецАтака, int СпецЗащита, int Скорость)
        {
            Name = имя;
            Types = Тип;
            HP = ХП;
            Attack = Атака;
            Defense = Защита;
            SpecialAttack = СпецАтака;
            SpecialDefense = СпецЗащита;
            Speed = Скорость;
        }

        public override string ToString()
        {
            return $"{Name} ({string.Join(", ", Types)})";
        }
    }

    public class Mesprit : Pokemon
    {
        public Mesprit() : base("Месприт", new[] { "Физический" }, 5, 7, 7, new[] { "Metal Sound", "Leer", "Confide", "Scald", }, 7, 5)
        {
        }
    }
}