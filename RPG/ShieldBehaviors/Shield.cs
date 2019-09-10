using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.ShieldBehaviors
{
    class Shield : IShieldBehavior
    {
        int value = 0;

    public Shield(int value)
    {
        this.value = value;
    }

    public void DoDamage(int incoming, Avatars.Avatar target)
    {
        Console.WriteLine("The " + target.Name + "'s shield absorbs " + value);
        target.Life -= incoming - value;
    }
}
}
