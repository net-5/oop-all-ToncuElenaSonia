using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Butterfly : Insect,IFly
    {
        
        public Butterfly(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll butterflies are moving with some speed!");
        }

        public void Fly()
        {
            Console.WriteLine($"The {Name} is a insect that can fly with the maximum speed of {Speed} km/h!");
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
    }
}
