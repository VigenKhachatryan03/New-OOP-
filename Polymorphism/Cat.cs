using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Cat:Animal
    {
        public Cat(int Dcount)
        {
            Console.WriteLine();
            for (int i = 0; i < Dcount; i++)
            {
                Console.Write($" {i + 1}  -  ");
                sound();
            }
        }
        public override void sound()
        {
            Console.WriteLine("Cat's sound");
        }
    }
}
