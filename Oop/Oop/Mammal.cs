using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }
        
        public override void Move()
        {
            Console.WriteLine("All mammals are moving with some speed!");
        }
    }
}
