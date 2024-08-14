using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic;

public static class Linq //Language Integrated Query
{
   static double[] marks = [90.5, 87.3, 37.5, 78.9, 40.0, 78.6, 88.9];

    static List<Student> students = [
        new ("Ram Bista", new DateTime(1990, 12, 12),"NCIT","BIT"),
        new ("Binisha Awale", new DateTime(2001, 04, 12),"Vedas", "BCS"),
        new ("Sita Silwal", new DateTime(1989, 02, 25),"Ascol", "BECE"),
        new ("Laxman Shrestha", new DateTime(2005, 08, 23),"Xavier", "BCA"),
        new("Hari Basnet", new DateTime(2000, 09, 12), "CCRC","BSC")
    ];

    //Get all marks which surpass passmark 40
    public static void LearnLinq()
    {
        //Imperative
        List<double> passMarks = [];
        foreach (var mark in marks)
        {
            if (mark > 40)
            {
                passMarks.Add(mark);
            }
        }

        //Declarative
        var passMarks1 = marks.Where(mark => mark > 40); //filter

        var result = marks.Select(x => x.ToString("F2")); //projection
        foreach (var mark in result)
        {
            Console.WriteLine(mark);
        }

        //implicite case
        //byte b= 35;
        //int x = b;

        //explicite case
        //int x = 424;
        //y = byte(x);

        //get all passmarks converted to nearest integer
        //Method syntax
        var passMarksInt = marks.Where(mark => mark > 40).Select(x => Math.Round(x));
        foreach (var  x in passMarksInt)
        {
            Console.WriteLine(x);
        }
        //Expression syntax
        passMarksInt = from mark in marks
                       where mark > 40
                       select Math.Round(mark);

        //Get all students who are born after 2000 AD
        var youngerStudent = students.Where(x => x.dob.Year > 2000);

        //Get student name with their ages and order by age
        var emps = students
            .Select(x => new { Name = x.name, Age = x.CalculateAge() })
            .OrderBy(x => x.Age.Item2);

        foreach(var item in emps)
        {
            Console.WriteLine($"{item.Name}\t{item.Age.Item1}");

        }


    }
}
