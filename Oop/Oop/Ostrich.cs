using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Ostrich : Bird,IWalk
    {
        
        public Ostrich(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll ostriches are moving with some speed!");
        }
        public void Walk()
        {
            Console.WriteLine($"The {Name} is a bird that can walk with the maximum speed {Speed} km/h!");
        }
        public void Walk(int speed)
        {
            if (speed >= Speed)
            {
                Console.WriteLine($"The {Name} can't walk with the speed of {speed} km/h, the {Name} can only walk with the maximum speed of {Speed} km/h!");
            }
            else
            {
                Walk();
            }
        }
    }
}
