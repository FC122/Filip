using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
     class Resistance
    {
        int Physical;
        int Magic;

        public Resistance()
        {
            Physical = 1;
            Magic = 1;
        }
        public int GetPhysical()
        {
            return Physical;
        }
        
        public int GetMagic()
        {
            return Magic;
        }
    }
}
