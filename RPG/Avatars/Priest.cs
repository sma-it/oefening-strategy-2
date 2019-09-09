using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Priest : Avatar
    {
        public Priest() : base("Priest") { }

        public override void Attack(Avatar target)
        {
            Console.WriteLine(Name + " casts a spell on " + target.Name + " with 4 damage");
            target.doDamage(4);
        }

        public override void Display()
        {
            Console.WriteLine("This is a Priest with " + Life + " life");
        }
    }
}
