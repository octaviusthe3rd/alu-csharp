using System;
using System.Collections.Generic;

class List
{
       public static int Sum(List<int> myList)
    {
        int total = 0;
        List<int> unique = new List<int>{};
    
        foreach (int item in myList)
        {
            if (!unique.Contains(item))
            {
                unique.Add(item);
            }
        }

        foreach (int item in unique)
        {
            total += item;
        }

        return total;
    }
}