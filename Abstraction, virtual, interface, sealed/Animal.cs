using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction__virtual__interface__sealed
{
    abstract class Animal
    {
        abstract public string Name { get; set; }

       abstract public string SetName();
      abstract  public string GetName();
        abstract public void Eat();
    }
}
