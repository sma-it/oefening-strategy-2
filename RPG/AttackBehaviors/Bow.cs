using RPG.Avatars;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.AttackBehaviors
{
    class Bow : IAttackBehavior
    {
        private int damage = 0;
        public int Damage => damage;

        public Bow(int damage)
        {
            this.damage = damage;
        }

        public void Attack(Avatar attacker, Avatar target)
        {
            Console.WriteLine(attacker.Name + " shoots " + target.Name + " with " + Damage + " damage");
            target.doDamage(damage);
        }
    }
}
