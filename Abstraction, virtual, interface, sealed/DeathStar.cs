using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__virtual__interface__sealed
{
    class DeathStar : SpaceStation
    {
        public override void FireLaser()
        {
         Console.WriteLine("Pew Pew");
        }
    }
}
