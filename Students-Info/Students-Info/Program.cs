using OopsSession;
using System.Security.Cryptography.X509Certificates;

namespace OopsSession
{

    public class Program
    {
        public String getDetails(Person p)
        {
            if(p is Man)
            {
                Man man = (Man)p;
                return $"Id is {man.Id} Name is {man.Name} Age is {man.Age} Playing {man.playing}";
            }
            if (p is Woman)
            {
                Woman woman = (Woman)p;
                return $"Id is {woman.Id} Name is {woman.Name} Age is {woman.Age} PlayAndManage {woman.playAndManage}";
            }
            if (p is Child)
            {
                Child child = (Child)p;
                return $"Id is {child.Id}  Name is {child.Name} Age is {child.Age} Crying {child.crying}";
            }
            return $"Name is {p.Name} Age is {p.Age}";
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            //Person person = new Person { Id = 1, Name = "p1", Age=14 };
            Person person = new Person(1,"p1",14);

            //Person p2 = new Man { Id = 2, Name = "m1", playing = "yes" , Age=20};
            Person p2 = new Man(2,"m1",20,"yes");

            //Person p3 = new Woman { Id = 3, Name = "w1", playAndManage = "yes" , Age=40};
            Person p3 = new Woman(3,"w1",40,"yes");

            //Person p4 = new Child { Id = 4, Name = "c1", crying = "yes", Age = 40 };
            Person p4 = new Child(4,"c1",40,"yes");

            Console.WriteLine(program.getDetails(person));
            Console.WriteLine(program.getDetails(p2));
            Console.WriteLine(program.getDetails(p3));
            Console.WriteLine(program.getDetails(p4));

        }
    }
}