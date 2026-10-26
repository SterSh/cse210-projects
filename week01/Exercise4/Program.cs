using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input;
        List<int> numbers = new List<int>();

        int sum = 0;
        double avg;
        int max = 0;

        do
        {
            Console.Write("Enter Number:");
            string rawInput = Console.ReadLine();
            input = int.Parse(rawInput);

            if (input != 0)
            {
                numbers.Add(input);
            }


        } while (input != 0);

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        avg = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}