using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ShieldBehaviors
{
    class Curse : IShieldBehavior
    {
        int value = 0;

        public Curse(int value)
        {
            this.value = value;
        }

        public void DoDamage(int incoming, Avatars.Avatar target)
        {
            Console.WriteLine("The " + target.Name + " is cursed. Damage is multiplied by " + value);
            target.Life -= incoming * value;
        }
    }
}
