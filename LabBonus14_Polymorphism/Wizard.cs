using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus14_Polymorphism
{
    class Wizard:MagicUsingCharacter
    {
        public int SpellNumber { set; get; }

        public Wizard(string charName, int charStrength, int charIntel, int wizEnergy, int wizSpell) : base(charName, charStrength, charIntel, wizEnergy)
        {
            SpellNumber = wizSpell;
        }

        public override void Play()
        {
            Console.WriteLine("WIZARD"+new string('*',44));
            Console.WriteLine($"{"Name",-10}{"Strength",-10}{"Intel",-10}{"Energy",-10}{"Spell",-10}");
            Console.WriteLine($"{Name, -10}{Strength, -10}{Intelligence, -10}{MagicalEnergy, -10}{SpellNumber, -10}");
        }
    }
}
