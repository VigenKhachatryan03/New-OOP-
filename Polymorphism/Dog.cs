using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Dog : Animal
    {
        public Dog(int Dcount)
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
            Console.WriteLine("Dog's sound");
        }
    }
}
