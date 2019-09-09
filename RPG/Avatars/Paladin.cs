using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Paladin : Avatar
    {
        public Paladin()
            : base(
                  "Paladin",
                  new AttackBehaviors.Sword(6),
                  new ShieldBehaviors.Shield(2)
                  )
        { }
    }
}
