using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus14_Polymorphism
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public string Name { set; get; }
        public int Strength { set; get; }
        public int Intelligence { set; get; }

        public GameCharacter (string charName, int charStrength, int charIntel)
        {
            Name = charName;
            Strength = charStrength;
            Intelligence = charIntel;
        }

        public virtual void Play()
        {
            Console.WriteLine(Name);
        }
    }
}
