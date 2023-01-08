using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int userNum = -1;
        while (userNum != 0)
        {
        
            Console.WriteLine("Enter number: ");
            string userStr = Console.ReadLine();
            userNum = int.Parse(userStr);

            if (userNum != 0)
            {
                numList.Add(userNum);
            }




        }

        int sum = 0;
        foreach (int number in numList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");






    }
}