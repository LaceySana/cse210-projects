public class ReflectingActivity : Activity
{

    private List<string> _prompts = [
        "Think of a time when you did something really difficult.",
        "Think of a time when you sacrificed your time for others.",
        "Think of a time when you went out of your comfort zone to serve someone.",
        "Think of a time when you stood up for yourself."
    ];
    private List<string> _questions = [
        "How did you feel afterwards?",
        "What was your favorite thing about this experience?",
        "What is one thing you would do differently in a similar situation?",
        "What is something new you learned from this experience?"
    ];

    // CONSTRUCTORS

    public ReflectingActivity()
    {
        SetActivityName("Reflecting Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }


    // METHODS

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("\nNow ponder each on the following questions as they related to this experience.");
        Console.Write("\nYou may begin in: ");
        DisplayCountDown(5);
        RunForDuration(DisplayQuestion);

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);

        return _questions[randomIndex];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" --- {GetRandomPrompt()} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestion()
    {
        Console.Write($"\n > {GetRandomQuestion()} ");
        DisplaySpinner(GetActivityDuration()/2);
    }

}

