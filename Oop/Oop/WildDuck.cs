using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public class WildDuck : Bird,ISwim,IFly,IWalk
    { 
       
        public WildDuck(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll wild ducks are moving with some speed!");
        }

        public void Swim()
        {
            Console.WriteLine($"The {Name} is a bird that can swim with the maximum speed {Speed} km/h!");
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
        public void Fly()
        {
            Console.WriteLine($"\nThe {Name} is a bird that can fly with the maximum speed of {Speed} km/h!");
        }
        public void Fly(int speed)
        {
            if (speed >= Speed)
            {
                Console.WriteLine($"The {Name} can't fly with the speed of {speed} km/h, the {Name} can only fly with the maximum speed of {Speed} km/h!");
            }
            else
            {
                Fly();
            }
        }

        public void Walk()
        {
            Console.WriteLine($"\nThe {Name} is a bird that can walk with the maximum speed of {Speed} km/h!");
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
