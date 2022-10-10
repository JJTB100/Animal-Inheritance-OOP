using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    class Animal
    {
        protected string name;

        protected int hunger;
        
        public void Eat()
        {
            Console.WriteLine($"{name} just ate something");
        }

        
    }
}
