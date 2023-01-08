using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "yes";
        do
        {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        

        string guess = "";
        int nGuess = 0;
        int count = 0;

        while (nGuess != number )
        {
        count = count + 1;
        Console.Write("What is the magic number? ");
        Console.Write("What is your guess? ");
        guess = Console.ReadLine();
        nGuess = int.Parse(guess);
        
        if (nGuess < number)
        {
            Console.WriteLine("Higher. Guess again" );            
        }
        else if (nGuess > number)
        {
            Console.WriteLine("Lower. Guess again");
            
        }
        else
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took {count} tries");
        }
        }   Console.Write("Do you want to continue? ");
            input = Console.ReadLine();
        }
            while (input == "yes");
        



    }
}