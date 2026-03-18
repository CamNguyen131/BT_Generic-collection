using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };

        int sum = list.Sum();

        Console.WriteLine("Tong = " + sum);

        Console.ReadKey();
    }
}