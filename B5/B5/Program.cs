using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>() { "An", "Binh", "Cuong" };

        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();

        list.Remove(name);

        list.ForEach(x => Console.WriteLine(x));

        Console.ReadKey();
    }
}