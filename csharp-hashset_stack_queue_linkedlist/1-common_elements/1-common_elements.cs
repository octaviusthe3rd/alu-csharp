using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        foreach (int item in list1)
        {
            if (list2.Contains(item) && !result.Contains(item))
            {
                result.Add(item);
            }
        }

        SortList(result);
        return result;
    }

    public static void SortList(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int current = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > current)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = current;
        }
    }
}