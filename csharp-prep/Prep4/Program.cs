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
        //foreach loop to add the sum of numbers

        int sum = 0;
        foreach (int number in numList)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //find the average. use float data type
        float average = ((float)sum) / numList.Count;
        Console.WriteLine($"The average is: {average}");   

        //find the max
        int max = numList[0];

        foreach(int number in numList)
        {
            if (number>max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The Max number is {max}");


        //find the min
        int min = numList[0];

        foreach(int number in numList)
        {
            if (number<min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min number is {min}");


        //sort the list in order








    }
}