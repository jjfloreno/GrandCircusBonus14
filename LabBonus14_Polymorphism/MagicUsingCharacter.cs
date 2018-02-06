using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus14_Polymorphism
{
    class MagicUsingCharacter:GameCharacter
    {
        public int MagicalEnergy { set; get; }

        public MagicUsingCharacter(string charName, int charStrength, int charIntel, int wizEnergy) : base(charName, charStrength, charIntel)
        {
            MagicalEnergy = wizEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"{0,-10}/{1,-10}/{2,-5}/{3,-5}","Player","Strength", "Intel","Energy");
            Console.WriteLine($"{Name, -10}{Strength, -10}{Intelligence, -5}{MagicalEnergy, -10}");
        }
    }
}
