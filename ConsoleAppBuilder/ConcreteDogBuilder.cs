using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBuilder
{
    internal class ConcreteDogBuilder : DogBuilder
    {
        Dog Dog = new Dog();
        public ConcreteDogBuilder()
        {
            Dog.Toys = new List<string>();
        }
        public override void SetName(string name)
        {
            Dog.Name = name;
        }
        public override void SetBreed(string breed)
        {
            Dog.Breed = breed;
        }
        public override void SetAge(int age)
        {
            Dog.Age = age;
        }
        public override void AddToy(string toys)
        {
            Dog.Toys.Add(toys);
        }
        public override Dog GetInfo()
        {
            return Dog;
        }
    }
}
