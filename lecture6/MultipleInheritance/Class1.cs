using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleInheritance
{
    // IBird1 Interface
    public interface IBird1
    {
        void fly();
        void land();
    }

    //IBird2 Interface
    public interface IBird2
    {
        void eat();
        void fly();
    }

    // Multiple Inheritance
    public class Bird : IBird1, IBird2
    {
        void IBird2.fly()
        {
            Console.WriteLine("Bird2 fly");
        }
        public void eat()
        {
            Console.WriteLine("Bird Eat");
        }

        void IBird1.fly()
        {
            Console.WriteLine("Bird1 fly");
        }
        public void land()
        {
            Console.WriteLine("Bird land");
        }
    }
}
 