public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts =[
        "When have you felt the spirit?",
        "What small things have you accomplished?",
        "What are you grateful for?"
        ];

    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("");
    }

    public void Run()
    {
        DisplayListCount();
    }

    private void DisplayListCount()
    {
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} things.");
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
        string listItem = Console.ReadLine();
        userList.Add(listItem);
        return userList;
    }
}