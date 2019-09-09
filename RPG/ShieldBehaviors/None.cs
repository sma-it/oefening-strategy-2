using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ShieldBehaviors
{
    class None : IShieldBehavior
    {
        public void DoDamage(int incoming, Avatars.Avatar target)
        {        
            target.Life -= incoming;
        }
    }
}
