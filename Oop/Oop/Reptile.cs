using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("\nAll the repiles are moving with some speed!");
        }
    }
}
