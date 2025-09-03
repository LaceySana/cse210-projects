using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNum;

        do
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());

            if (guessNum > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessNum != magicNumber);
            

        
    }
}