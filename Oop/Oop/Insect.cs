using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Insect : Animal
    {
        public Insect(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("\nAll the instects are moving with some speed!");
        }
    }
}
