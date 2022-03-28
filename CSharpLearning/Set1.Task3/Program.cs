using System;

namespace Set1.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tharani";
            DateTime joiningDate = new DateTime(2021, 8, 24);

            Console.WriteLine($"My name is {firstName}");
            Console.WriteLine($"I joined MumsWhoCode on {joiningDate.ToString("d")}");
            Console.ReadLine();
        }
    }
}
