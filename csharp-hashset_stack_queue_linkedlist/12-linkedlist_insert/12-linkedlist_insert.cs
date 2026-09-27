using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int>? current = myLList.First;

        while (current != null)
        {
            if (current.Value > n)
            {
                return myLList.AddBefore(current, n);
            }
            current = current.Next;
        }

        // reached the end without finding a bigger value, so it goes last
        return myLList.AddLast(n);
    }
}