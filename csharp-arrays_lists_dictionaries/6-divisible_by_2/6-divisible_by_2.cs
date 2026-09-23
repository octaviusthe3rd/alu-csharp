using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        for (int x = 0; x < myList.Count; x++)
        {
            result.Add(myList[x] % 2 == 0);
        }

        return result;
    }
}