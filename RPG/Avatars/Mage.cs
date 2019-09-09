using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Mage : Avatar
    {
        public Mage() : base("Mage") { }

        public override void Attack(Avatar target)
        {
            Console.WriteLine(Name + " casts a spell on " + target.Name + " with 10 damage");
            target.doDamage(4);
        }

        public override void doDamage(int damage)
        {
            Console.WriteLine("The mage takes double damage");
            life -= damage * 2;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Mage with " + Life + " life");
        }
    }
}
