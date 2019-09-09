using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Warrior : Avatar
    {
        public Warrior() : base("Warrior") { }

        public override void Attack(Avatar target)
        {
            Console.WriteLine(Name + " hits " + target.Name + " with 7 damage");
            target.doDamage(7);
        }

        public override void doDamage(int damage)
        {
            Console.WriteLine("The warrior's shield absorbs 1 damage");
            life -= damage - 1;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Warrior with " + Life + " life");
        }
    }
}
