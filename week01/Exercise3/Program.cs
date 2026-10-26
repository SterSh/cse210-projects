using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please guess a number between 1 and 100");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess;

        do
        {

            Console.Write("What is your guess?");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}