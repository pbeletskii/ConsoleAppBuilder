using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBuilderVersion2
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _age;
        private List<string> _toys;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public List<string> Toys
        {
            get { return _toys; }
            set { _toys = value; }
        }

        public class Builder
        {
            private Dog _dog;

            public Builder()
            {
                _dog = new Dog();
            }

            public Builder WithName(string name)
            {
                _dog.Name = name;
                return this;
            }

            public Builder WithBreed(string breed)
            {
                _dog.Breed = breed;
                return this;
            }

            public Builder WithAge(int age)
            {
                _dog.Age = age;
                return this;
            }

            public Builder WithToys(List<string> toys)
            {
                _dog.Toys = toys;
                return this;
            }

            public Dog Build()
            {
                return _dog;
            }
        }
    }
}
