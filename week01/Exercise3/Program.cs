using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 101);

        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower!");
            }
        }
    }
}