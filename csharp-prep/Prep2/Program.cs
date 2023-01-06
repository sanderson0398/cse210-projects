using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);





        if (number>90)
        {
            Console.WriteLine($"You passed with an A, {number}%");
        }
        else if (number>80)
        {
            Console.WriteLine($"You passed with a B, {number}%");
        }
        else if (number>70)
        {
            Console.WriteLine($"You passed with a C, {number}%");
        }
        else if (number>60)
        {
            Console.WriteLine($"You failed with a D, {number}%");
        }
        else if (number>50)
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        else if (number>40)
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        else if (number>30)
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        else if (number>20)
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        else if (number>10)
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        else 
        {
            Console.WriteLine($"You failed with a F, {number}%");
        }
        
    }
}