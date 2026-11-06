using System;

class Program
{

    //STERTCH CHALLENGE: loading my prompts from a file as well as using a default prompt if load fails. 
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        //Pass in prompt file to get prompts
        PromptGenerator getPrompt = new PromptGenerator("prompts.txt");

        int menuSelection = 0;
        string file = "";

        Console.Clear();

        while (menuSelection != 5)
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string selection = Console.ReadLine();
            int.TryParse(selection, out menuSelection);

            if (menuSelection == 1)
            {
                //get date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                //pass prompt file to get prompt

                string prompt = getPrompt.GetRandomPrompt();

                Console.WriteLine($"{prompt}");

                Entry userEntry = new Entry();

                userEntry._promptText = prompt;
                userEntry._date = dateText;
                userEntry._entryText = Console.ReadLine();

                journal.AddEntry(userEntry);

            }
            else if (menuSelection == 2)
            {
                journal.DisplayAll();
            }
            else if (menuSelection == 3)
            {
                Console.WriteLine("What is the filename?");
                file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (menuSelection == 4)
            {
                Console.WriteLine("What is the filename?");
                file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (menuSelection == 5)
            {
                //do nothing and exit loop
            }
            else
            {

                Console.WriteLine("Please make a selection from the menu items");
            }
        }

    }
}