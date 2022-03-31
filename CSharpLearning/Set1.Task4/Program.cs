using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 5;
            int c;

            Console.WriteLine("a value : " + a);
            Console.WriteLine("b value : " + b);

            c = a + b;
            Console.WriteLine("Add a and b values : " + c);

            a = ++a;
            b = --b;
            Console.WriteLine("\na value : " + a);
            Console.WriteLine("b value : " + b);

            c = a - b;
            Console.WriteLine("Subtract a and b values : " + c);

            a = ++a;
            b = --b;
            Console.WriteLine("\na value : " + a);
            Console.WriteLine("b value : " + b);

            c = a * b;
            Console.WriteLine("Muliply a and b values : " + c);

            a = ++a;
            b = --b;
            Console.WriteLine("\na value : " + a);
            Console.WriteLine("b value : " + b);

            c = a / b;
            Console.WriteLine("Divide a and b values : " + c);
            Console.ReadLine();

        }
    }
}        
