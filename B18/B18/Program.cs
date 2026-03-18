using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {
            new Student{Name="An", Score=7.5},
            new Student{Name="Binh", Score=9.0},
            new Student{Name="Cuong", Score=8.5}
        };

        double max = list[0].Score;

        foreach (var s in list)
        {
            if (s.Score > max) max = s.Score;
        }

        foreach (var s in list)
        {
            if (s.Score == max)
            {
                Console.WriteLine(s.Name + " - " + s.Score);
            }
        }

        Console.ReadKey();
    }
}