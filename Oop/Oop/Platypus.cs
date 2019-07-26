using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public class Platypus : Mammal,IWalk, ISwim
    {
        public Platypus(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("All platypuses can move with some speed!");
        }
        public void Swim()
        {
            Console.WriteLine($"The {Name} is a mammal that can swim with a maximum of speed {Speed} km/h!");
        }
        public void Swim(int speed)     
        {
            if (speed >= Speed)
            {
                Console.WriteLine($"The {Name} can't swim with the speed of {speed} km/h, the {Name} can only swim with the maximum speed of {Speed} km/h!");
            }
            else
            {
                Swim();
            }
            
        }
        public void Walk()
        {
            Console.WriteLine($"The {Name} is a mammal that can walk with a maximum of speed {Speed} km/h!");
        }

        public void Walk(int speed)
        {
            if (speed >= Speed)
            {
                Console.WriteLine($"The {Name} can't walk with the speed of {speed} km/h, the {Name} can only walk with the maximum speed of {Speed} km/h!");
            }
            else
            {
                Swim();
            }
        }
      
    }
}
