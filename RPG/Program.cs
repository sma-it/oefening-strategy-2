using System;
using RPG.Avatars;

namespace RPG
{
    class Program
    {
        
        static Avatar hunter = new Hunter();
        static Avatar mage = new Mage();
        static Avatar paladin = new Paladin();
        static Avatar priest = new Priest();
        static Avatar warrior = new Warrior();

        static Avatar target = priest;
        static Avatar selected = warrior;
        
        static void Main(string[] args)
        {
            SMUtils.Menu mainMenu = new SMUtils.Menu();
            mainMenu.AddOption('1', "Show Status", ShowStatus);
            mainMenu.AddOption('2', "Select Target", SelectTarget);
            mainMenu.AddOption('3', "Control Avatar", ControlAvatar);
            mainMenu.AddOption('4', "Attack Target", AttackTarget);

            mainMenu.AddOption('5', "Equip Superior Sword", 
                () => selected.SetWeapon(new AttackBehaviors.SuperiorSword(7))
            );

            mainMenu.AddOption('6', "Equip Superior Bow",
                () => selected.SetWeapon(new AttackBehaviors.SuperiorBow(12))
            );

            mainMenu.Start();
        }

        static void ShowStatus()
        {
            hunter.Display();
            mage.Display();
            paladin.Display();
            priest.Display();
            warrior.Display();
        }

        static void SelectTarget()
        {
            SMUtils.Menu menu = new SMUtils.Menu();
            menu.AddOption('1', "Select Hunter", () => { target = hunter; Console.WriteLine(target.Name + " is targetted"); });
            menu.AddOption('2', "Select Mage", () => { target = mage; Console.WriteLine(target.Name + " is targetted"); });
            menu.AddOption('3', "Select Paladin", () => { target = paladin; Console.WriteLine(target.Name + " is targetted"); });
            menu.AddOption('4', "Select Priest", () => { target = priest; Console.WriteLine(target.Name + " is targetted"); });
            menu.AddOption('5', "Select Warrior", () => { target = warrior; Console.WriteLine(target.Name + " is targetted"); });

            menu.Start();
        }

        static void ControlAvatar()
        {
            SMUtils.Menu menu = new SMUtils.Menu();
            menu.AddOption('1', "Control Hunter", () => { selected = hunter; Console.WriteLine(selected.Name + " is active"); });
            menu.AddOption('2', "Control Mage", () => { selected = mage; Console.WriteLine(selected.Name + " is active"); });
            menu.AddOption('3', "Control Paladin", () => { selected = paladin; Console.WriteLine(selected.Name + " is active"); });
            menu.AddOption('4', "Control Priest", () => { selected = priest; Console.WriteLine(selected.Name + " is active"); });
            menu.AddOption('5', "Control Warrior", () => { selected = warrior; Console.WriteLine(selected.Name + " is active"); });

            menu.Start();
        }

        static void AttackTarget()
        {
            selected.Attack(target);
        }
    }
}
