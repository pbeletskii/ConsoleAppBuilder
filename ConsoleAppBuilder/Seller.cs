using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBuilder
{
    internal class Seller
    {
        DogBuilder builder;
        public Seller(DogBuilder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.SetName("Buddy");
            builder.SetAge(3);
            builder.SetBreed("Labrador Retriever");
            builder.AddToy("Frisbee");
            builder.GetInfo();
        }
    }
}
