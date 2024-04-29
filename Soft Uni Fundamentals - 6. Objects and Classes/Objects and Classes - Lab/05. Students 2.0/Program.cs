using System;
using System.Configuration.Assemblies;

class Student
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}
    public string City {get; set;}
}

class Students2
{
    static Student GetStudent (List<Student> students, string firstName, string LastName)
    {
        Student existingStudent = null;

        foreach (Student student in students)
        {
            if(student.FirstName == firstName && student.LastName == LastName)
            { existingStudent = student;}
        }

        return existingStudent;
    }

    static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
    {
        foreach (Student student in students)
        {
            if(student.FirstName == firstName && student.LastName == lastName)
            {
                return true;
            }
        }
        
        return false;
    }
    static void Main()
    {
       List<Student> students = new List<Student>();

       string line = Console.ReadLine();
       while (line != "end")
       {
        string[] tokens = line.Split();

        string firstName = tokens[0];
        string lastName = tokens[1];
        int age = int.Parse(tokens[2]);
        string city = tokens[3];

        if (IsStudentExisting(students, firstName, lastName))
        {
            Student student = GetStudent(students, firstName, lastName);

            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = age;
            student.City = city;
        }

        else
        {
        Student student = new Student()
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            City = city
        };

        students.Add(student);
        }
        line = Console.ReadLine();
       }

    
       string filterCity = Console.ReadLine();

       List<Student> filteredStudents = students
       .Where(s => s.City == filterCity)
       .ToList();

       foreach(Student student in filteredStudents)
       { Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."); }
    }
}