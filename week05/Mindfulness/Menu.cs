using System.Linq.Expressions;

public class Menu
{
    private string _menu = """
    
    Menu Options:
      1. Start breathing activity
      2. Start reflecting activity
      3. Start listing activity
      4. Quit
    """;

    private BreathingActivity _breathing = new BreathingActivity();
    private ReflectingActivity _reflecting = new ReflectingActivity();
    private ListingActivity _listing = new ListingActivity();


    public void RunApplication()
    {
        while (true)
        {
            DisplayMenu();
            InitiateSelectedOption(GetUserChoice());
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine(_menu);
    }

    private int GetUserChoice()
    {
        List<int> options = [1, 2, 3, 4];
        int userChoiceNum;
        do
        {
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();
            int.TryParse(userChoice, out userChoiceNum);
        } while (!options.Contains(userChoiceNum));
        return userChoiceNum;
    }

    private void InitiateSelectedOption(int menuOption)
    {
        if (menuOption == 1)
        {
            _breathing.Run();
        }
        else if (menuOption == 2)
        {
            _reflecting.Run();
        }
        else if (menuOption == 3)
        {
            _listing.Run();
        }
        else if (menuOption == 4)
        {
            Console.WriteLine("\nSee you next time!");
            Environment.Exit(0);
        }
    }
}