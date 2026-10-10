using System;

class Int
{
    public static void divide(int a, int b)
    {
        int Result = 0;

        try
        {
            Result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {Result}");
        }
    }
}