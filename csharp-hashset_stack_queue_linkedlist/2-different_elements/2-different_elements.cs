﻿using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> nList = new List<int>();
        foreach (var item in list1)
        {
            if (!list2.Contains(item))
                nList.Add(item);
        }
        foreach (var item in list2)
        {
            if (!list1.Contains(item))
                nList.Add(item);
        }
        nList.Sort();
        return nList;
    }
}