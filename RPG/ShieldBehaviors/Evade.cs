using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ShieldBehaviors
{
    class Evade : IShieldBehavior
    {
        int value = 0;

        public Evade(int value)
        {
            this.value = value;
        }

        public void DoDamage(int incoming, Avatars.Avatar target)
        {
            Console.WriteLine("The " + target.Name + " evades " + value + " damage");
            target.Life -= incoming - value;
        }
    }
}
