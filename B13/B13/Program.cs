using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"}
        };

        Console.Write("Nhap ten: ");
        string key = Console.ReadLine();

        foreach (var s in list)
        {
            if (s.Name.ToLower().Contains(key.ToLower()))
            {
                Console.WriteLine(s.Name);
            }
        }

        Console.ReadKey();
    }
}