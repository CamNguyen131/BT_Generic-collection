using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "An", "Binh", "Cuong" };

        Console.Write("Nhap ten: ");
        string name = Console.ReadLine();

        bool found = false;

        foreach (string s in list)
        {
            if (s == name) found = true;
        }

        if (found) Console.WriteLine("Ton tai");
        else Console.WriteLine("Khong ton tai");

        Console.ReadKey();
    }
}