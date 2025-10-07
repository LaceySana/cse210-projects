// Breathing Activity class : inherit from Activity
public class BreathingActivity : Activity
{
    // CONSTRUCTORS

    public BreathingActivity()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    // METHODS

    public void Run()
    {
        DisplayStartingMessage();

        RunForDuration(Breath);

        DisplayEndingMessage();
    }

    private void Breath()
    {
        Console.Write("\n\nBreath in... ");
        DisplayCountDown(4);
        Console.Write("\nBreath out... ");
        DisplayCountDown(6);
    }
}