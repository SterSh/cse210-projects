using System;

class Program
{
    // STRETCH CHALLENGE: implemented a hint functionality to reveal a single hidden word when the user types "hint".
    // STRETCH CHALLENGE: Hiding a word only selects from words that are not already hidden.
    static void Main(string[] args)
    {
        string input;
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Reference scriptureReference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(scriptureText, scriptureReference);
        bool allDone = false;

        do
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press Enter to continue or type 'quit' to finish (type 'hint' to show a word):");
            input = Console.ReadLine();

            // STRETCH CHALLENGE
            if (input == "hint")
            {
                scripture.ShowRandomWord();
            }
            else
            {
                allDone = scripture.IsCompletelyHidden();
                scripture.HideRandomWords(3);
            }
        }
        while (input != "quit" && allDone == false);
    }
}