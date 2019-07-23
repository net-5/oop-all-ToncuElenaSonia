using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Viper : Reptile, IMove,ICrawl
    {
        public Viper(string name) : base(name)
        {
        }
        public override void Move()
        {
            Console.WriteLine("\nAll vipers are moving with some speed!");
        }
        public void Crawl()
        {
            Console.WriteLine($"The {Name} is a reptile that can crawl with the maximum speed of {Speed} km/h!");
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
