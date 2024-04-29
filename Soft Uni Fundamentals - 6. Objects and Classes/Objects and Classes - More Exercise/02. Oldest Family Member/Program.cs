using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Family
{
    private List<Person> people;

    public Family()
    {
        people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        Person oldestMember = null;
        int maxAge = int.MinValue;

        foreach (Person person in people)
        {
            if (person.Age > maxAge)
            {
                maxAge = person.Age;
                oldestMember = person;
            }
        }

        return oldestMember;
    }
}

class OldestFamilyMember
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new Person { Name = name, Age = age };
            family.AddMember(person);
        }

        Person oldestMember = family.GetOldestMember();
        Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);
    }
}
