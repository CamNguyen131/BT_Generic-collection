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

        foreach (var s in list)
        {
            Console.WriteLine(s.Id + " - " + s.Name);
        }

        Console.ReadKey();
    }
}