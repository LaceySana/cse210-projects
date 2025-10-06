// Base class
public class Activity
{
    // ATTRIBUTES

    string _activityName;
    string _activityDescription;
    int _activityDuration = 0;


    // CONSTRUCTORS

    public Activity() {}


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
        Console.WriteLine($"{_activityName} \n {_activityDescription}");
        GetDurationFromUser();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great Job! \nYou have completed {_activityDuration} seconds of {_activityName}!");
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
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

}