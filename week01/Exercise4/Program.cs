using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int newNum = -1;
        while (newNum != 0)
        {
            Console.Write("Enter a number: ");
            newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
            
        }

        int sum = 0;
        int maxNum = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > maxNum)
            {
                maxNum = num;
            }
        }
        Console.WriteLine($"The sum is {sum}.");

        int numAvg = sum / numbers.Count;
        Console.WriteLine($"The average is {numAvg}.");

        Console.WriteLine($"The largest number is {maxNum}.");

    }
}