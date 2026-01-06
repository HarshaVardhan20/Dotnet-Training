using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace XmlSeriealization
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public List<int> scores { get; set; }

    }

    public class Student
    {
        public string name {get;set;}

        public int age {get;set;}

        public int rollNo {get;set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Person",
                Age = 30,
                Email = "person@example.com",
                scores = new List<int> { 85, 90, 95 },
            };    

            // Create an XmlSerializer for the Person type

            // Serialize the object to XML
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Person));

            // Console.WriteLine("Serialized XML:");
            // x.Serialize(Console.Out,person);

            Student student = new Student
            {
                name = "Student1",
                age=20,
                rollNo=1
            };

            // Json serializer
            string studentJson = JsonSerializer.Serialize(student);

            Console.WriteLine(studentJson);

            Console.WriteLine("Delegation Method Addition");

            Deligate deligateObject = new Deligate();

            deligateObject.Delegation(3,5);
        }
    }
}


