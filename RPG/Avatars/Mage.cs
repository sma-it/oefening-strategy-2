using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Mage : Avatar
    {
        public Mage()
            : base(
                  "Mage",
                  new AttackBehaviors.Spell(10),
                  new ShieldBehaviors.Curse(2)
                  )
        { }
    }
}
