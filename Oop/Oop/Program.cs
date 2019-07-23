using System;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Platypus newPlatypus = new Platypus("platypus1");         
            Bat newBat = new Bat("bat1");
            //mammal's behavior
            //depending on the way they move, they have a maximum speed.
            newPlatypus.Speed = 4;
            newPlatypus.Move();
            newPlatypus.Swim();
            newPlatypus.Swim(5);
            newPlatypus.Speed = 5;
            newPlatypus.Walk();
            newPlatypus.Walk(10);
            newBat.Speed = 20;
            newBat.Move();
            newBat.Fly();
            newBat.Fly(30);

            //fish's behavior
            //depending on the way they move, they have a maximum speed.
            Crucian newCrucian = new Crucian("crucian1");
            Shark newShark = new Shark("shark1");
            newCrucian.Speed = 10;
            newCrucian.Move();
            newCrucian.Swim();
            newCrucian.Swim(15);
            newCrucian.Speed = 30;
            newShark.Move();
            newShark.Swim();
            newShark.Swim(40);

            //bird's behavior
            //depending on the way they move, they have a maximum speed.
            WildDuck newWildDuck = new WildDuck("wild duck1");
            Ostrich newOstrich = new Ostrich("ostrich1");
            newWildDuck.Speed = 5;
            newWildDuck.Move();
            newWildDuck.Swim();
            newWildDuck.Swim(10);
            newWildDuck.Speed = 10;
            newWildDuck.Fly();
            newWildDuck.Fly(15);
            newWildDuck.Speed = 10;
            newWildDuck.Walk();
            newWildDuck.Walk(20);
            newOstrich.Speed = 15;
            newOstrich.Move();
            newOstrich.Walk();
            newOstrich.Walk(30);

            //insect's behavior
            //depending on the way they move, they have a maximum speed.
            Butterfly newButterfly = new Butterfly("butterfly1");
            Bug newBug = new Bug("bug1");
            Caterpillar newCaterpillar = new Caterpillar("caterpillar1");
            newButterfly.Speed = 5;
            newButterfly.Move();
            newButterfly.Fly();
            newButterfly.Fly(10);
            newBug.Speed = 2;
            newBug.Move();
            newBug.Walk();
            newBug.Walk(5);
            newCaterpillar.Speed = 1;
            newCaterpillar.Move();
            newCaterpillar.Crawl();
            newCaterpillar.Crawl(5);

            //repile's behavior
            //depending on the way they move, they have a maximum speed.

            Crocodile newCrocodile = new Crocodile("crocodile1");
            Viper newViper = new Viper("viper1");
            newCrocodile.Speed = 10;
            newCrocodile.Move();
            newCrocodile.Swim();
            newCrocodile.Swim(20);
            newCrocodile.Speed = 2;
            newCrocodile.Walk();
            newCrocodile.Walk(5);
            newViper.Speed = 5;
            newViper.Move();
            newViper.Crawl();
            newViper.Crawl(10);


        }
    }
}
