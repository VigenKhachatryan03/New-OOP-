using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird E_Obj = new eagle();
            Bird H_Obj = new hawk();
            E_Obj.flying();
            H_Obj.flying();
            E_Obj.sound();
            H_Obj.sound();


        }
    }
}
