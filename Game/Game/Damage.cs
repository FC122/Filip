namespace Game
{
     class Damage
    {
        int Physical;
        int Magic;
        int True;

        public Damage()
        {
            Physical = 100;
            Magic = 50;
            True = 10;
        }

        public int GetPhysical()
        {
            return Physical;
        }

        public int GetMagic()
        {
            return Magic;
        }

        public int GetTrue()
        {
            return True;
        }

        public int TotalDamage()
        {
            return True + Magic + Physical;
        }
    }
}
