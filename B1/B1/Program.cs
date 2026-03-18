using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        list.ForEach(x => Console.WriteLine(x));

        Console.ReadKey();
    }
}