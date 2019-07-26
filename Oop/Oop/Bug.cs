using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Bug : Insect, IWalk
    {
       
        public Bug(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll bugs are moving with some speed!");
        }
        public void Walk()
        {
            Console.WriteLine($"The {Name} is a insect that can walk with the maximum speed of {Speed} km/h!");
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
