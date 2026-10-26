using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your name:");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}