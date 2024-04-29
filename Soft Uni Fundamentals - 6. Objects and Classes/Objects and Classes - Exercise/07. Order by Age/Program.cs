using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }

    public Person(string name, string id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }
}

class Order_By_Age
{
    static void Main()
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] data = input.Split(' ');
            string name = data[0];
            string id = data[1];
            int age = int.Parse(data[2]);

            if (people.ContainsKey(id))
            {
                people[id].Name = name;
                people[id].Age = age;
            }
            else
            {
                Person person = new Person(name, id, age);
                people.Add(id, person);
            }
        }

        List<Person> sortedPeople = people.Values.OrderBy(p => p.Age).ToList();

        foreach (Person person in sortedPeople)
        {
            Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
        }
    }
}
