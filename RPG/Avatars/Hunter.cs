using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    class Hunter : Avatar
    {
        public Hunter() 
            : base(
                  "Hunter",
                  new AttackBehaviors.Bow(4),
                  new ShieldBehaviors.Evade(2)
                  )
        { }
    }
}
