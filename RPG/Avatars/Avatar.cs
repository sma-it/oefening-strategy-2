using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    abstract class Avatar
    {
        AttackBehaviors.IAttackBehavior attackBehavior;
        ShieldBehaviors.IShieldBehavior shieldBehavior;

        private string name;
        public string Name { get => name; }

        public int Life { get; set; } = 100;

        public Avatar(
            string name, 
            AttackBehaviors.IAttackBehavior attackBehavior, 
            ShieldBehaviors.IShieldBehavior shieldBehavior)
        {
            this.name = name;
            this.attackBehavior = attackBehavior;
            this.shieldBehavior = shieldBehavior;
        }

        public void PrintStatus()
        {
            if(Life > 0)
            {
                Console.WriteLine(Name + " has " + Life + " life left");
            } else
            {
                Console.WriteLine(Name + " has died");
            }
        }

        public void Attack(Avatar target)
        {
            attackBehavior.Attack(this, target);
        }

        public void doDamage(int damage)
        {
            shieldBehavior.DoDamage(damage, this);
        }

        public void SetWeapon(AttackBehaviors.IAttackBehavior attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public void Display()
        {
            if(Life > 0)
            {
                Console.WriteLine("This is a " + Name + " with " + Life + " life");
            } else
            {
                Console.WriteLine("This " + Name + " is dead!");
            }
            
        }
    }
}
