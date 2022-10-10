using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name)
        {
            this.name = name;
        }

        public void Squeak()
        {
            Console.WriteLine($"Sqeak Squeak");
        }
        public void Hibernate()
        {
            Console.WriteLine($"{name} just went to sleep");
        }
    }
}