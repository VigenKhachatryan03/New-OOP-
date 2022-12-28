using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class eagle : Bird
    {
        public override void sound()
        {
            Console.WriteLine("eagle's sound");
        }
        public override void flying()
        {
            Console.WriteLine("Yu-Huuu");
        }
    }
}
