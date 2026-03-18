using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 3, 7, 2, 9, 5 };

        int max = list[0];

        foreach (int x in list)
        {
            if (x > max) max = x;
        }

        Console.WriteLine("Max = " + max);
        Console.ReadKey();
    }
}