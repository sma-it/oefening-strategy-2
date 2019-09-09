using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Hunter : Avatar
    {
        public Hunter() : base("Hunter") { }

        public override void Attack(Avatar target)
        {
            Console.WriteLine(Name + " shoots " + target.Name + " with 4 damage");
            target.doDamage(4);
        }

        public override void doDamage(int damage)
        {
            Console.WriteLine("The hunter evades 2 damage");
            life -= damage - 2;
        }

        public override void Display()
        {
            Console.WriteLine("This is a Hunter with " + Life + " life");
        }
    }
}
