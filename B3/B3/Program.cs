using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 3, 9, 2, 5 };

        Console.WriteLine("Max = " + list.Max());

        Console.ReadKey();
    }
}