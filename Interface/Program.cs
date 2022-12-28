using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant A_Obj = new Ant();
            A_Obj.sound();
            A_Obj.run();
            A_Obj.die();
        }
    }
}
