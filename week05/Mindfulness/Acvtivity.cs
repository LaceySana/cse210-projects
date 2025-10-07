// Base class
public class Activity
{
    // ATTRIBUTES

    private string _activityName;
    private string _activityDescription;
    private int _activityDuration = 0;
    private int _completions = 0;
    


    // CONSTRUCTORS

    public Activity() { }


    // METHODS

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public void SetActivityDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }


    private void GetDurationFromUser()
    {
        Console.Write("How long (in seconds) would you like to spend on this activity? \n >> ");
        int seconds = int.Parse(Console.ReadLine());
        _activityDuration = seconds;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"| {_activityName} | \n\n{_activityDescription}\n");
        GetDurationFromUser();
        Console.Write("Get ready...");
        DisplaySpinner(5);
    }

    public void DisplayEndingMessage()
    {
        _completions++;
        Console.WriteLine($"\n\nGreat Job! \nYou have completed {_activityDuration} seconds of {_activityName}. \nYou have completed the {_activityName} {_completions} times in this session.");
    }

    public void DisplayCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplaySpinner(int seconds)
    {
        List<string> spinnerStrings = ["|", "/", "-", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void RunForDuration(Action action)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {
            action();
        }
    }


}