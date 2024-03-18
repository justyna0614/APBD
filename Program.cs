using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name}!");

        int[] numbers = { 2, 6, 4};
        int avg = Avg(numbers);
        int max = Max(numbers);
        Console.WriteLine($"AVG= {avg}");
        Console.WriteLine($"MAX= {max}");
    }

    public static int Avg(int[]arr)
    {
        int sum = 0;
        int size = arr.Length;
        foreach (int number in arr)
        {
            sum +=  number;
        }
        return sum / size;
    }

    public static int Max(int[] arr)
    {
        int max = 0;
        foreach (int number in arr)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}