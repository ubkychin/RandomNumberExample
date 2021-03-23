using System;

namespace RandomNumberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(200);

            if (randomNumber > 50) {
                System.Console.WriteLine($"{randomNumber} is greater than 50");
            } else if (randomNumber == 50) {
                System.Console.WriteLine($"{randomNumber} is equal to 50");
            } else {
                System.Console.WriteLine($"{randomNumber} is less than 50");
            }

        }
    }
}
