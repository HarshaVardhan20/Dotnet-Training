namespace question1
{
    public class Person
    {
        public string name{get;set;}
        public string Address{get;set;}
        public int Age{get;set;}

    }
    public class PersonImplementation{
        public string GetName(IList<Person> people)
        {   
            string name = "";
            for(int i = 0; i < people.Count; i++)
            {
                name += people[i].name;
                name+=" ";
                name += people[i].Address;
                name+=" ";
            }
            return name;
        }

        public decimal Average(IList<Person> people)
        {
            decimal total = 0;
            foreach(var person in people){
                total += person.Age;
            }
            return total/people.Count;
        }

        public int Max(IList<Person> people)
        {
            int maxi = 0;
            foreach(var person in people)
            {
                if (person.Age > maxi)
                {
                    maxi = person.Age;
                }
            }
            return maxi;
        }
    }
    public class Program
    {
        public static void Main()
        {
            IList<Person> p = new List<Person>();
            PersonImplementation pi = new PersonImplementation();
            p.Add(new Person{name="Arya", Address="A2101", Age=69});
            p.Add(new Person{name="Daniel", Address="D104", Age=40});    
            p.Add(new Person{name="Ira", Address="H801", Age=25});    
            p.Add(new Person{name="Jennifer", Address="I1704", Age=33});    
            
            Console.WriteLine(pi.GetName(p));
            Console.WriteLine(pi.Average(p));
            Console.WriteLine(pi.Max(p));
        }
    }
}