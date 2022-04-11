namespace Set1.Task5
{
    internal class Program
    {
        static void Main(string[] args)
         {

             DateTime todayDate = DateTime.Today;
             Console.WriteLine("Today's Date: " + todayDate.ToString("d"));

             Random randomNumber = new Random();
             int generatedRandomNumber = randomNumber.Next(1,15);
             
             Console.WriteLine("\nGenerated Random Number :" + generatedRandomNumber);

             todayDate = todayDate.AddDays(generatedRandomNumber);

             Console.WriteLine($"\nRandom Number added to Today's Date: {todayDate.ToString("d")}");
             Console.ReadLine();
        }
    }
}


        