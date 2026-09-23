using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestKey = "None";
        int bestValue = -1;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > bestValue)
            {
                bestValue = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}