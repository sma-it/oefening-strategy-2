using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Warrior : Avatar
    {
        public Warrior()
            : base(
                  "Warrior",
                  new AttackBehaviors.Sword(7),
                  new ShieldBehaviors.Shield(1)
                  )
        { }
    }
}
