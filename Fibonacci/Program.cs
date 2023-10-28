using System;

public class Program
{
    public static void GenerateFibonacci(int n)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}  ", first);
            next = first + second;
            first = second;
            second = next;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of terms for Fibonacci Series:");
        int n = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacci(n);
    }
}
