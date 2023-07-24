using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    internal class Dog : Animal
    {   
        public void IHaveFourLegs()
        {
            Console.WriteLine(" I have four legs");
            Console.ReadKey();
        }
    }
}
