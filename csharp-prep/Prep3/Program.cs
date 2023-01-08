using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        

        string guess = "";
        int nGuess = 0;
        
        while (nGuess != number )
        {
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
        }
        }
        



    }
}