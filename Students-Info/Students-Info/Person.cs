using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSession
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(int id, string name, int age) 
        {
            Id = id;
            Age = age;
            Name = name;
        }
        
    }

    public class Man: Person
    {
        public string playing { get; set; }
        public Man(int id, String name, int age, String p): base(id,name, age){
            playing = p;
        }
    }
       
    public class Woman: Person
    {
        public string playAndManage { get; set; }
        public Woman(int id, String name, int age, String p) : base(id, name, age)
        {
            playAndManage = p;
        }
    }

    public class Child : Person
    {
        public string crying { get; set; }
        public Child(int id, String name, int age, String p) : base(id, name, age)
        {
            crying = p;
        }
    }
}
