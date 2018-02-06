using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus14_Polymorphism
{
    class GameApp
    {
        static void Main(string[] args)
        {
            GameCharacter Warlock = new Warrior("Warlock", 10, 5, "Axe");
            GameCharacter Grunt = new Warrior("Grunt", 8, 6, "Sword");
            GameCharacter Merlin = new Wizard("Merlin", 4, 10, 8, 66);
            GameCharacter Gandolf = new Wizard("Gandolf", 6, 9, 7, 31);
            GameCharacter Ozzy = new Wizard("Ozzy", 8, 5, 4, 22);

            GameCharacter[] gameCharacters = new GameCharacter[5] { Warlock, Grunt, Merlin, Gandolf, Ozzy };

            //print output
            for (int i = 0; i < gameCharacters.Length; i++)
            {
               gameCharacters[i].Play();
            }
        }
    }
}
