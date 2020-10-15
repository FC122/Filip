using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Resistance R=new Resistance();
            Damage D=new Damage();
            Character Deku = new Character();

            Console.WriteLine(Deku.GetHP());
            Deku.TakeDamage();
            Console.WriteLine(Deku.GetHP());
 
        }
    }
}
