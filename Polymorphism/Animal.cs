using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        public Animal()
        {

        }
        public Animal(int count)
        {
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.Write($" {i+1}  -  ");
                sound();

            }

        }
        public virtual void sound()
        {
            Console.WriteLine("I am animal");
        }
    }
}
