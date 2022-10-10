using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    internal class Dog : Animal
    {
        List<string> objects = new List<string> { "ball", "cat", "stick" };
        Random r = new Random();

        public Dog(string name)
        {
            this.name = name;
        }

        public void Fetch()
        {
            int index = r.Next(objects.Count);
            Console.WriteLine($"{name} just fetched a {objects[index]}");
        }
        public void RollOver()
        {
            Console.WriteLine($"{name} just rolled over");
        }
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
}