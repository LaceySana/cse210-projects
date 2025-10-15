using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity(23, 2);
        CyclingActivity cycling = new CyclingActivity(30, 11);
        SwimmingActivity swimming = new SwimmingActivity(10, 12);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine("\n · " + activity.GetSummary());
        }
    }
}