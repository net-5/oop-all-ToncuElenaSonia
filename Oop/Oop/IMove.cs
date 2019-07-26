using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    interface IMove
    {
        void Move();
        int Speed { get; set; }
    }
}
