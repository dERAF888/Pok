using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pok3
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

    public class Electrode : Pokemon
    {
        public Electrode() : base("Электрод", new[] { "Электрический" }, 4, 3, 5, new[] { "Confide", "Swagger", "Sludge Bomb", "Energy Ball", }, 5, 9)
        {
        }
    }
}