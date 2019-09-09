using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Paladin : Avatar
    {
        public Paladin() : base("Paladin") { }

        public override void Attack(Avatar target)
        {
            Console.WriteLine(Name + " hits " + target.Name + " with 6 damage");
            target.doDamage(7);
        }

        public override void doDamage(int damage)
        {
            Console.WriteLine("The warrior's shield absorbs 2 damage");
            life -= damage - 2;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Paladin with " + Life + " life");
        }
    }
}
