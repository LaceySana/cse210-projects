// Exceeded requirements by marking a goal's completion with an infinity symbol if it is an EternalGoal. (I don't like seeing it unmarked if I did it...)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}