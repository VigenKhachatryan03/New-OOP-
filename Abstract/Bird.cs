using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Bird
    {
        private static int count = 0;
        public Bird()
        {
            count++;
            Console.Write(count);
            Console.WriteLine(" - NEW obj Bird");
            Console.WriteLine();
        }

        public abstract void sound();
        public virtual void flying()
        {
            Console.WriteLine("Yu-Huuu");
        }

    }
}
