using RPG.Avatars;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.AttackBehaviors
{
    class SuperiorBow : IAttackBehavior
    {
        private int damage = 0;
        public int Damage => damage;

        public SuperiorBow(int damage)
        {
            this.damage = damage * 3;
        }

        public void Attack(Avatar attacker, Avatar target)
        {
            Console.WriteLine(attacker.Name + " shoots " + target.Name + " with " + Damage + " damage");
            target.doDamage(damage);
        }
    }
}
