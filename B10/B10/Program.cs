using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 5, 2, 8, 1 };

        int min = list[0];

        foreach (int x in list)
        {
            if (x < min) min = x;
        }

        Console.WriteLine("Min = " + min);
        Console.ReadKey();
    }
}