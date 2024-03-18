using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.WriteLine($"Hello, {name}!");

        int[] numbers = { 2, 4, 6};
        int avg = Avg(numbers);
        Console.WriteLine($"AVG= {avg}");
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
}