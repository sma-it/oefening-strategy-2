using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ShieldBehaviors
{
    interface IShieldBehavior
    {
        void DoDamage(int incoming, Avatars.Avatar target);
    }
}
