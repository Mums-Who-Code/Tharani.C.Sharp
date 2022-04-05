namespace Set1.Task4
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
            Console.WriteLine("Multiply a and b values : " + c);

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
