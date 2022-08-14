
using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {


            MyObject myObject = new MyObject();
            MyObject myObject2 = new MyObject(10, 10);
            myObject.Calculate(10, 15);
            //MyObject myObject = new MyObject(10, 5);

            //myObject.number1 = 10;
            //myObject.number2 = 5;

            //Console.WriteLine($"Number 1 is {myObject.number1}");
            //Console.WriteLine($"Number 2 is {myObject.number2}");
            Console.WriteLine($"{myObject.MyMethod()} {myObject.number3}");
            Console.WriteLine($"{myObject2.MyMethod()} {myObject2.number3}"); 
            Console.ReadLine();
        }
    }
    
}
