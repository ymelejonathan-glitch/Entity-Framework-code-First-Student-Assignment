using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var db = new SchoolContext())
        {
            var student = new Student
            {
                Name = "John Smith"
            };

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine("Student added successfully!");
            Console.WriteLine("Student ID: " + student.StudentId);
            Console.WriteLine("Student Name: " + student.Name);
        }
    }
}
