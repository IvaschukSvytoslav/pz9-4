using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Func<int, int[]> generateFibonacci = count =>
        {
            if (count <= 0) return new int[0];
            if (count == 1) return new int[] { 0 };
            if (count == 2) return new int[] { 0, 1 };

            int[] fibArray = new int[count];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (int i = 2; i < count; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            return fibArray;
        };

        Console.WriteLine("Введіть кількість чисел Фібоначчі:");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] fibonacciNumbers = generateFibonacci(count);
        Console.WriteLine($"Числа Фібоначчі: {string.Join(", ", fibonacciNumbers)}");
    }
}
