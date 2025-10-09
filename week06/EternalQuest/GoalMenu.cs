using System.Security.Cryptography;

public static class GoalMenu
{
    private static List<String> _options = [
        "Create New Goal",
        "List Goals",
        "Record Event",
        "Save Goals",
        "Load Goals",
        "Quit"
    ];

    public static void DisplayMenu()
    {
        int i = 0;
        Console.WriteLine("\nMenu Options:");
        foreach (string option in _options)
        {
            i++;
            Console.WriteLine($"  {i}: {option}");
        }
    }

    public static string GetUserChoice()
    {
        Console.Write("Select a choice from the menu: ");
        string userCoice = Console.ReadLine();
        return userCoice;
    }
}