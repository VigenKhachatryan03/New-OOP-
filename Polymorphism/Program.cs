using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal CAnimObj = new Animal(5);
            Animal CDogObj = new Dog(3);
            Animal CCatObj = new Cat(3);

            Console.WriteLine();
            CAnimObj.sound();
            CDogObj.sound();
            CCatObj.sound();


        }
    }
}
