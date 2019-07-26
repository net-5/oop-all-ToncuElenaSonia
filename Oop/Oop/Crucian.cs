using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public class Crucian : Fish,ISwim
    {
        
        public Crucian(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll crucians can move with some speed!");
        }
        public void Swim()
        {
            Console.WriteLine($"The {Name} is a fish that can swim with the maximum speed of {Speed} km/h!");
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
    }
}
