using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);

        string letter = "";





        if (number>90)
        {
            letter = "A";
        }
        else if (number>80)
        {
            letter = "B";
        }
        else if (number>70)
        {
           letter = "C";
        }
        else if (number>60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        int result;

        int remanNumber = Math.DivRem(number, 10, out result);    
        
        string mark = "";


        if (remanNumber>= 7)
        {
            mark = "+";
        }
        else if (7> remanNumber && remanNumber <3)
        {
            mark = "";
        }
        else
        {
            mark = "-";
        }





        if (number>70)
        {
            Console.WriteLine($"You passed with an {letter}{mark}");
        }
        else 
            Console.WriteLine($"You got an {letter}{mark}. You did not pass, but you will next time");
    }
}