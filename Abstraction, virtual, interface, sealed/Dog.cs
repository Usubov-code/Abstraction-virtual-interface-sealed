using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__virtual__interface__sealed
{
    class Dog : Animal
    {
        public override string Name { get ; set ; }

        public override void Eat()
        {
            Console.WriteLine($"Dog {Name} is Eating");
        }

        public override string GetName()
        {
            return this.Name;
        }

        public override string SetName()
        {
            return this.Name;
        }
    }
}
