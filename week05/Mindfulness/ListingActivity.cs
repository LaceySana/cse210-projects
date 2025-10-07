public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts = [
        "When have you felt the spirit?",
        "What small things have you accomplished this week?",
        "What are you grateful for?",
        "Who has been a light in your life?"
        ];

    public ListingActivity()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"\nList as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in:");
        DisplayCountDown(5);
        Console.WriteLine();
        DisplayListCount();

        DisplayEndingMessage();
    }


    private void DisplayListCount()
    {
        _count = GetListFromUser().Count;
        Console.WriteLine($"\nYou listed {_count} things.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        RunForDuration(() => GetList(userList));
        return userList;
    }
    private void GetList(List<string> list)
    {
        Console.Write(" >> ");
        string listItem = Console.ReadLine();
        list.Add(listItem);
    }

}