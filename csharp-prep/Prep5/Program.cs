using System;

class Program
{
    
        
        static void DisplayMessage()
        {
                Console.WriteLine("Welcome to the Program! ");
        }

        static string  PromptUserName()
        {
                Console.Write("Type User Name: ");
                string name = Console.ReadLine();
                return name;
                
        }
        

        static int PromptUserNumber()
        {
                Console.Write("What is your favorite number?: ");
                string favNumStr = Console.ReadLine();
                int favNum = int.Parse(favNumStr);
                return favNum;

        } 

        static int SquareNumber(int num)
        {
                        
                int sqNum = num*num; //Math.Pow(num,2);
                return sqNum;         
   
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
        static void Main(string[] args)
        {       
                DisplayMessage();
                string name = PromptUserName();
                                
                int favNum = PromptUserNumber();
                int sqNum = SquareNumber(favNum);
                DisplayResult(name, sqNum);              
        }






    }
