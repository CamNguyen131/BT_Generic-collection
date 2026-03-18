using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string str = Console.ReadLine();

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (count.ContainsKey(c))
                count[c]++;
            else
                count[c] = 1;
        }

        foreach (var item in count)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadKey();
    }
}