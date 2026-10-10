using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int Count = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                Count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // n was out of range, so we stop and return what we printed
        }

        return Count;
    }
}