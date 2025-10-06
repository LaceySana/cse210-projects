// Breathing Activity class : inherit from Activity
public class BreathingActivity : Activity
{
    // CONSTRUCTORS

    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("Calm your mind by breathing at a slow, steady pace.");
    }

    // METHODS

    public void Run()
    {
        DisplayStartingMessage();

        DisplayCountDown(3);
        DisplaySpinner(GetActivityDuration());
        
        DisplayEndingMessage();
    }

    // Override

}