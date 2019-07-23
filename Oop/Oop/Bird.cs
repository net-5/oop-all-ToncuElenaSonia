using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("\nAll the birds are moving with some speed!");
        }
    }
}
