using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Animal:IMove
    {
        private string name;
        private int speed;
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public int Speed { get { return speed; } set { speed = value; } }
        public abstract void Move();

    }
}
