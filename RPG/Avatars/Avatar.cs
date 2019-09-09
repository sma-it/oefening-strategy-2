using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Avatars
{
    abstract class Avatar
    {
        private string name;
        public string Name { get => name; }

        protected int life = 100;
        public int Life { get => life; }

        public Avatar(string name)
        {
            this.name = name;
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

        public virtual void Attack(Avatar target)
        {
            Console.WriteLine(Name + " hits " + target.Name + " with 5 damage");
            target.doDamage(5);
        }

        public virtual void doDamage(int damage)
        {
            life -= damage;
        }

        public abstract void Display();
    }
}
