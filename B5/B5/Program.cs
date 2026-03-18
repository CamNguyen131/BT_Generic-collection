using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "An", "Binh", "Cuong" };

        Console.Write("Nhap ten can xoa: ");
        string name = Console.ReadLine();

        list.Remove(name);

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();
    }
}