using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll the fish are moving with some speed!");
        }

    }
}
