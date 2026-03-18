using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };

        list.Reverse();

        foreach (int x in list)
        {
            Console.WriteLine(x);
        }

        Console.ReadKey();
    }
}