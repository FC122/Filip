using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
     class Character
    {
        int HP;
        Resistance Resistance=new Resistance();
        Damage Damage=new Damage();

        public Character(/*Resistance resistance, Damage damage*/)
        {
            HP = 1000;
           // Resistance = resistance;
            //Damage = damage;
        }
        public int GetHP()
        {
            return HP;
        }
        public void TakeDamage()
        {
            HP = HP - ((Damage.GetMagic() - Resistance.GetMagic()) + (Damage.GetPhysical() - Resistance.GetPhysical())+Damage.GetTrue());
        }

    }
}
