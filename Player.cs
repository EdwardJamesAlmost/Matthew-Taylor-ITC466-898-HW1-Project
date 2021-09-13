using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Template
{
    class Player
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public static void PlayerAttack(Player aPlayer)
        {
            aPlayer.Attack();
        }

        public virtual void Attack()
        {
            Random rand = new Random();
            int attackValue = rand.Next(1, Strength);
            Console.WriteLine($"{Name} attacked for {attackValue} damage.");
        }

    } // end class player



    // subclasses for Warrior and Wizards that inherit from the player Class needed to be written. The override Attack methods within the subclasses contain the 
    class Warrior : Player
    {
        public int Bonus { get; set; }

        public override void Attack()
        {
            Random rand = new Random();
            int attackValue = rand.Next(1, Strength) + Bonus;
            Console.WriteLine($"{Name} charges for {attackValue} (includes +{Bonus} bonus).");
        }
    } // end class Warrior


    class Wizard : Player
    {
        public int Energy { get; set; }

        public override void Attack()
        {
            Random rand = new Random();
            int attackValue = rand.Next(1, Strength);

            Console.WriteLine($"{Name} attacked for {attackValue} damage. \n \t (Wizard {Name} depleted {rand.Next(1, 10)} energy).");

        }

    }







} // end namespace
