using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Crocodile : Reptile,ISwim,IWalk
    {
       
        public Crocodile(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll crocodiles are moving with some speed!");
        }

        public void Swim()
        {
            Console.WriteLine($"The {Name} is a reptile that can swim with the maximum speed {Speed} km/h!");
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
            Console.WriteLine($"The {Name} is a reptile that can walk with the maximum speed {Speed} km/h!");
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
