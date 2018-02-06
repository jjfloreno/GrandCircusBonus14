using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus14_Polymorphism
{
    class Warrior:GameCharacter
    {
        public string WeaponType { set; get; }

        public Warrior(string charName, int charStrength, int charIntel, string charWeapon):base(charName, charStrength, charIntel)
        {
            WeaponType = charWeapon;
        }

        public override void Play()
        {
            Console.WriteLine("WARRIOR" + new string('*', 43));
            Console.WriteLine($"{"Name",-10}{"Strength",-10}{"Intel",-10}{"Weapon",-10}");
            Console.WriteLine($"{Name, -10}{Strength, -10}{Intelligence, -10}{WeaponType, -10}");
        }
    }
}
