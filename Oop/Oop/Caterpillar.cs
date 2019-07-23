using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Caterpillar : Insect,ICrawl
    {
       
        
        public Caterpillar(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll caterpillars are moving with some speed!");
        }

        public void Crawl()
        {
            Console.WriteLine($"The {Name} is a insect that can crawl with the maxmimum speed of {Speed} km/h!");
        }
        public void Crawl(int speed)
        {
            if (speed >= Speed)
            {
                Console.WriteLine($"The {Name} can't crawl with the speed of {speed} km/h, the {Name} can only crawl with the maximum speed of {Speed} km/h!");
            }
            else
            {
                Crawl();
            }
        }
    }
}
