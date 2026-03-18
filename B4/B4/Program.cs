using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 6 };

        int count = 0;

        foreach (int x in list)
        {
            if (x % 2 == 0) count++;
        }

        Console.WriteLine("So chan = " + count);
        Console.ReadKey();
    }
}