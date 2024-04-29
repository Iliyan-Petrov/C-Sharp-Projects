using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}

class Students
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstName = input[0];
            string lastName = input[1];
            double grade = double.Parse(input[2]);

            students.Add(new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            });
        }

        students.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));
        foreach (Student student in students)
        { Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}"); }
    }
}
