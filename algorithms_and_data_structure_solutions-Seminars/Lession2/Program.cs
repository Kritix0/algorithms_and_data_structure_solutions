using System;

namespace guess_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создали объект класса Random 
            Random rnd = new Random();

            ConsoleKeyInfo attempt;

            int max = 0;
            int min = 0;
            int gamesCount = 0;
            int tries = 0;

            do
            {
                gamesCount++;
                int currentTries = 0;
                int randomNumber = rnd.Next(1, 101);
                while (true)
                {
                    currentTries++;
                    int result = 0;
                    Console.WriteLine("Type desired number from 1 to 100");
                    while (!int.TryParse(Console.ReadLine(), out result) || result > 100 || result < 1)
                        Console.WriteLine("Error. Type desired number from 1 to 100");
                    if (result > randomNumber)
                        Console.WriteLine("Too much");
                    else if (result < randomNumber)
                        Console.WriteLine("Too few");
                    else
                    {
                        Console.WriteLine("U are winner!!!");
                        break;
                    }
                }
                tries += currentTries;
                max = max < currentTries ? currentTries : max; // if (max < currentTries) max = currentTries
                if (min == 0 || min > currentTries) min = currentTries;
                Console.WriteLine("U wanna to play again? Enter y/n");
                attempt = Console.ReadKey();
            } while (attempt.Key == ConsoleKey.Y);
            Console.WriteLine($"Max = {max} \nMin = {min} \nAvg = {(double)tries / gamesCount}");
        }
    }
}
