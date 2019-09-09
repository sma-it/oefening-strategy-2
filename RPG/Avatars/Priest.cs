using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Priest : Avatar
    {
        public Priest()
            : base(
                  "Priest",
                  new AttackBehaviors.Spell(4),
                  new ShieldBehaviors.None()
                  )
        { }
    }
}
