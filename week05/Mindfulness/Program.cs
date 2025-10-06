using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string menu = "";
        Console.WriteLine(menu);

        BreathingActivity activity1 = new BreathingActivity();
        activity1.Run();
    }
}