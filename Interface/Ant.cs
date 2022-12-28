using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Ant:Iinsect,IDie
    {

        private int MaxSpeed = 10;
        public void sound()
        {
            Console.WriteLine("Ant's sound");
        }
        public void run()
        {
            Console.WriteLine($"Max speed of Ant is {MaxSpeed}");  
        }

        public void die()
        {
            Console.WriteLine("I Die");
        }
    }
}
