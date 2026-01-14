using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LinqExample3
{
    public class Student
    {
        public int Id{get;set;}
    }
    public class Test
    {
        private static void Task1()
        {
            for(int i = 0; i <= 100; i += 2)
            {
                Thread.Sleep(100);
                Console.Write(i + " ");
            }
        }
        private static void Task2()
        {
            for(int i = 1; i < 100; i += 2)
            {
                Thread.Sleep(100);
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Object obj = new Object();
            Student student = new Student();
            GenericWithTwoDataType<Object, Student> genericWithTwoDataType = new GenericWithTwoDataType<object, Student>();
            var result = genericWithTwoDataType.GetDataType(obj, student);
            Console.WriteLine(result);

            // Predicate
            Predicate<int> isEven = number => number%2==0;
            Console.WriteLine(isEven(10));

            // Action 
            Action<string> logger = NewMethod();

            if (DateTime.Now.Hour < 12)
            {
                logger = GoodMoring();
            }
            else
            {
                logger = GoodDay();
            }

            logger("dd");

            logger = Method2();

            logger("Application Started"); // Invoking the Action

            // Function Delegate
            Func<int, int, string> multiplyResult = (x, y) =>
            {
                return $"{x} times {y} is {x*y}";
            };

            Console.WriteLine(multiplyResult(3,5)); 
            
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            t1.Start();
            t2.Start();
        }
         private static Action<string> GoodDay()
        {
            
            return message =>
            {
                Console.WriteLine($"Good Morning to you");
            };
        }

        private static Action<string> NewMethod()
        {
            return message =>
            {
                Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");
            };
        }

        private static Action<string> GoodDay(string str)
        {
            return message =>
            {
                Console.WriteLine($"Good Day to you");
            };
        }

        private static Action<string> GoodMoring()
        {
            return message =>
            {
                Console.WriteLine($"Good Morning");
            };
        }

        private static Action<string> Method1()
        {
            return message =>
            {
                Console.WriteLine($"[LOG]: {message.ToUpper()} at {DateTime.Now}");
            };
        }

        private static Action<string> Method2()
        {
            return message =>
            {
                Console.WriteLine($"Welcome to Programming");
            };
        }
    }
    public class GenericWithTwoDataType<T, K>
    {
        public string GetDataType(T t, K k)
        {
            dynamic var1 = t.GetType().ToString();
            dynamic var2 = k.GetType().ToString();
            return var1 + " " +  var2;
        }
    }
}