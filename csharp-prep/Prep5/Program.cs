using System;

class Program
{
    static void Main(string[] args)
    {
        
        static void DisplayMessage()
        {
                Console.WriteLine("Welcome to the Program! ");
        }

        static void  PromptUserName()
        {
                Console.Write("Type User Name: ");
                string name = Console.ReadLine();
        }

        static void PromptUserNumber()
        {
                Console.Write("Type User Number: ");
                Console.ReadLine();
        } 

        static void SquareNumber()
        {
                
                Console.Write("What is your favorite number?: ");
                string favNum = Console.ReadLine();
                int intFavNum = int.Parse(favNum);
                int sqNum = intFavNum^2;         
   
        }

        /*static void DisplayResult(string name,int sqNum)
        {
                Console.WriteLine($"Hello {name}, your favorite num Squred is {sqNum}");
        }
        */

        static void DisplayResult(string name, int sqNum)
            {
                        Console.WriteLine($"Hello {name}, the square of your number is {sqNum}");
            }
            
        DisplayMessage();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult(name, sqNum);              







    }
}