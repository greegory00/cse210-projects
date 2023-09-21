using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            
            string num = Console.ReadLine();
            number = int.Parse(num);
                 
        
            if (number != 0)
            {
            numbers.Add(number);
            }




        }

        int sum = 0;
        foreach (int n in numbers)
        {
        sum += n;
        }
    
        float average = ((float)sum) / numbers.Count;

        int max = numbers[0];

        foreach (int nu in numbers)

        {
            if (nu > max)
            {
            max = nu;
            }
            
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}