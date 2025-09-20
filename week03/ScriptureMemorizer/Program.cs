// Exceeded Requirements: Only words that are not already hidden can be hidden. Also, any and all special characters are still shown.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project. \n");

        Reference scriptureRef = new Reference("Proverbs", 3, 5);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture newScripture = new Scripture(scriptureRef, scriptureText);

        string userInput = "";

        do
        {
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine("Click ENTER to continue or type 'QUIT' to quit.");
            userInput = Console.ReadLine();

            if (newScripture.IsCompletelyHidden())
            {
                break;
            }

            newScripture.HideRandomWords(3);
        } while (userInput.ToLower() != "quit");

    }
}