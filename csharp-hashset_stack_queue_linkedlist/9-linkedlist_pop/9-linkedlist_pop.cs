using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int>? head = myLList.First;

        if (head == null)
        {
            return 0;
        }

        int headValue = head.Value;
        myLList.RemoveFirst();
        return headValue;
    }
}