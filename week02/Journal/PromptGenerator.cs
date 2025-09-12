public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the high of your day?",
        "What's one thing you were inspired to do differently today?",
        "What is an act of kindness you witnessed today?",
        "Who made the biggest impression on you today?",
        "What are you most proud of yourself for today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }
}