// I improved the file saving and loading to be compatible with csv files that can be opened in excel

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal currentJournal = new Journal();

        string menuInput = null;
        do
        {
            Console.WriteLine("""

                Daily Journal
                1. New Entry
                2. Display Journal
                3. Save Journal
                4. Load Journal
                5. Quit
            """);
            Console.Write(" >> ");
            menuInput = Console.ReadLine();
            Console.WriteLine();

            if (menuInput == "1")
            {
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                PromptGenerator promptGen = new PromptGenerator();
                string randPrompt = promptGen.GetRandomPrompt();

                Console.WriteLine($"{string.Concat(Enumerable.Repeat('*', 100))}\n{dateText}\n{randPrompt}");
                Console.Write("\n > ");
                string responseInput = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._dateText = dateText;
                newEntry._promptText = randPrompt;
                newEntry._responseText = responseInput;

                currentJournal.AddEntry(newEntry);
            }
            else if (menuInput == "2")
            {
                currentJournal.DisplayJournal();
            }
            else if (menuInput == "3")
            {
                Console.Write("What file name would you like to save this journal as?\n >> ");
                string saveAs = Console.ReadLine();
                currentJournal.SaveJournal(saveAs);
            }
            else if (menuInput == "4")
            {
                Console.Write("Which file would you like to load from?\n >> ");
                string loadFrom = Console.ReadLine();
                currentJournal.LoadJournal(loadFrom);
            }
            else if (menuInput == "5")
            {
                Console.WriteLine("Thank You!");
            }
            else
            {
                Console.WriteLine("-Invalid Option-");
            }
        } while (menuInput != "5");
    }
}