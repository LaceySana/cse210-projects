using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int sqrNum = SquareNumber(favNum);
        DisplayResult(name, sqrNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int num)
    {
        int sqrNum = (int)Math.Pow(num, 2);
        return sqrNum;
    }

    static void DisplayResult(string name, int sqrNum)
    {
        Console.WriteLine($"{name}, your favorite number squared is {sqrNum}.");
    }
}