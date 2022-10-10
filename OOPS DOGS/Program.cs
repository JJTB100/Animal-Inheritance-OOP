using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog John = new Dog("John");
            Hedgehog Sam = new Hedgehog("Sam");

            John.Fetch();
            John.Eat();
            John.RollOver();
            John.Bark();

            Sam.Eat();
            Sam.Squeak();
            Sam.Hibernate();
            

        }
    }
}
