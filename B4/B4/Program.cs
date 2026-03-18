using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 4, 5, 6 };

        int count = list.Count(x => x % 2 == 0);

        Console.WriteLine("So chan = " + count);

        Console.ReadKey();
    }
}