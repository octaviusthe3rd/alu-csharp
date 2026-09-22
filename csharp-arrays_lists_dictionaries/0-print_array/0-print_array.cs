using System;

class Array
{
    public static int?[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] numbers = new int[size];

        for (int x = 0; x < size; x++)
        {
            numbers[x] = x;
            Console.Write(numbers[x]);
            if (x != size - 1)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();

        return numbers;
    }
}