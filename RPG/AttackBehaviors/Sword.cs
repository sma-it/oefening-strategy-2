using System;
using System.Collections.Generic;
using System.Text;
using RPG.Avatars;

namespace RPG.AttackBehaviors
{
    class Sword : IAttackBehavior
    {
        private int damage = 0;
        public int Damage => damage;

        public Sword(int damage)
        {
            this.damage = damage;
        }

        public void Attack(Avatar attacker, Avatar target)
        {
            Console.WriteLine(attacker.Name + " hits " + target.Name + " with " + Damage + " damage");
            target.doDamage(damage);
        }
    }
}
