using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            int x = int.Parse(Console.ReadLine());
            list.Add(x);
            sum += x;
        }

        Console.WriteLine("Tong = " + sum);
        Console.ReadKey();
    }
}