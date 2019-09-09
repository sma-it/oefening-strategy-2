using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.AttackBehaviors
{
    interface IAttackBehavior
    {
        int Damage { get; }
        void Attack(Avatars.Avatar attacker, Avatars.Avatar target);
    }
}
